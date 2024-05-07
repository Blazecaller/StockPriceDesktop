# Stock price tracker desktop application demo
A desktop application to notify user about stock prices over time

## How to run the application
Download the bin/debug folder from [here]([StockPriceDesktop/bin/Debug](https://github.com/Blazecaller/StockPriceDesktop/tree/385c74d88b0e01c88163bfc88e30cb0d707b470b/StockPriceDesktop/bin/Debug)), then run the executable file. 

Input any stock specifications and click on track button

Ex: NVDA:NASDAQ --> Brings you the stock prices of NVDIA. 

Refer to the preview below

## Functionality
- AngleSharp based HTTP client with HTML parsing
- Google Finance website stock price display
- Continous price tracking
  
## Project steps / short-term goals
- [x] Make a get request to a site and save the html content locally
- [x] Parse the response to pick individual elements by class names
- [x] Design a form application where user can interact with the client url
- [x] Handle incorrect stock name tags inputted by the user
- [x] Do the tracking continuously on an async task until user stops it
- [ ] Compare the stock's previous close value with the current value and update change rate X%
- [ ] Divide query bar into two parts: Corporate tag, Stock market tag
- [ ] TBD

## Application preview
![StockPriceDesktop_5XVoPsyiCg](https://github.com/Blazecaller/StockPriceDesktop/assets/55828485/0b8065b0-b3fd-4bf0-8d9b-03306a10939c)
