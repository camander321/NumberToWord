
# Numbers To Words

#### By Cameron Anderson & Dalia Ramos

## Description
Translates a number into words

## Specifications
* display form requesting a date
- example input: "1384"

* take two smallest digits from input
- example input: "1384"
- example output: "84"

  - if number is between 10 and 19 return value from teens dictionary
    - example input: "16"
    - example output: "sixteen"

  - otherwise return value from tens and ones dictionaries
    - example input: "32"
    - example output: "Thirty, Two"

* loop through rest of number starting with the next smallest digit and take value from ones dictionary. Append a place value label according to which digit it is.

* Display result to view



## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/camander321/WeekdayFinder.git'.
* run the command 'dotnet restore' to download the necessary packages.
* run the command 'dotnet run' to build and run the server on localhost.
* use your preferred web browser to navigate to localhost:5000


## Support and contact details

* contact the author at chamburg321@gmail.com

## Technologies Used

* C#
* Asp .NET Core MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Cameron Anderson & Dalia Ramos

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
