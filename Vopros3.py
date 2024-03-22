import pyspark
from pyspark.sql import SparkSession
spark = SparkSession.builder.appName('Dataframe2').getOrCreate()

data1 = [["1", "milkProducts"], 
         ["2", "meatProducts"], 
         ["3", "beverages"],
         ["4", "fishProducts"]] 

data2 = [["1", "sourCream"],
         ["2", "yogurt"],
         ["3", "chicken"],
         ["4", "cheese"],
         ["5", "water"],
         ["6", "bread"],
         ["7", "milk"],
         ["8", "tomato"]]

dataKeys = [["1", "1"],
            ["2", "1"],
            ["2", "3"],
            ["3", "2"],
            ["4", "1"],
            ["5", "3"],
            ["7", "1"],
            ["7", "3"]
           ]
    
columns1 = ["id", "category"] 
columns2 = ["id", "product"]
keycolumns = ["productid", "categoryid"]

dataframe1 = spark.createDataFrame(data1, columns1)
dataframe2 = spark.createDataFrame(data2, columns2)
dataframekeys = spark.createDataFrame(dataKeys, keycolumns)

def MyMethod(dataframe1, dataframe2, dataframekeys):
    join1 = dataframe2.join(dataframekeys,dataframe2.id == dataframekeys.productid, "outer")
    join2 = join1.join(dataframe1,join1["categoryid"] == dataframe1.id)
    print("Все пары «Имя продукта – Имя категории»:")
    res = join2.select(join2["product"], join2["category"]).show()
    
    join3 = join1.join(dataframe1,join1["categoryid"] == dataframe1.id, "anti")
    listOfProducts = join3.select(join3["product"]).collect()
    print("Имена продуктов, у которых нет категорий:")
    print(listOfProducts[0].__getitem__('product'), listOfProducts[1].__getitem__('product'))

MyMethod(dataframe1, dataframe2, dataframekeys)