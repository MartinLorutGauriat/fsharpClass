type ItemsName =
    | Doll
    | Toaster
    | Stick
    | Movie
    | Mouse
    | Phone
    | Binks
    | Poney

type ItemsPrice =
    | DollPrice 
    | ToasterPrice
    | StickPrice
    | BinksPrice
    | PhonePrice
    | PoneyPrice

type Items = ItemsName * ItemsPrice

type Info = 
    | PhoneInfo

type DetailledItems = ItemsName * ItemsPrice * Info

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

type Language = 
    | English
    | French
    | Spanish
    | German
    | Italian

type Currency = 
    | Euro
    | Dollar
    | Livre

type Menu = Language * Currency * Basket * Account * ItemsName * ItemsPrice 

type PayButtons = 
    | Done
    | Paypal

type CreditCard = 
    | Number
    | ExpirationDate
    | SecurityCode

type Pay = CreditCard * PayButtons
    