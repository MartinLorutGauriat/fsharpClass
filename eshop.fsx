type ItemsName =
    | Doll
    | Toaster
    | Stick
    | Movie
    | Mouse
    | Phone
    | Binks
    | Poney

type ItemPrice =
    | DollPrice
    | ToasterPrice
    | StickPrice
    | BinksPrice
    | PhonePrice
    | PoneyPrice

type Items = ItemsName * ItemPrice

type Info = 
    | PhoneInfo

type DetailledItems = ItemsName * ItemPrice * Info

type Account =
    | Name
    | Adress

type BasketButtons = 
    | Remove
    | Pay

type BasketDisplay = 
    | ItemsName
    | ItemsPrice
    | Quantity
    | Total
    | GrandTotal

type Basket = BasketDisplay * BasketButtons 
