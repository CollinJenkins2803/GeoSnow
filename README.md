MIST-353: Prototype Development and Research for Web Application
 =============================================================================
 ![Nice Pic](/Assingment_2_MIST-353-001/wwwroot/Logo.png)

For this assignment:

 **My Competitive Analysis**

1. [Carolina Cabin Rentals](https://www.carolinacabinrentals.com/)
    >Carolina Cabin Rentals is more of a local website meaning that they only provide data for resorts and cabin rentals in the states of North and South Carolina. This is a great inspiration to my project due to its interactive home page. this is what I would like my home page to reference as my development continues. During inspection of this site I was able to find their use of API's for their map. I was also able to find their custom CSS and bootstrap. I would like to replicate the resizing css that allows their page to be seen in different sizes. All in all, I would like to use this website as the crude basis for what my home page will eventually end up looking like.

2. [On The Snow](https://www.onthesnow.com/)
    > On The Snow provides customers with a user friendly experience that allows them to search for the resort or region they are looking for, while also providing a container that holds all of their most popular searches. This site offers snow reports so you can take a look at the snowfall for whatever resort you plan on going to. On the technical side of things, this site seems to use custom css as well as bootstrap 5. After inspecting I was able to see their use of API's in order to recieve the weather data provided to users. Overall this website is a great inspiration as it has all the requirements that I would like to include into my project.
    

3. [Ski](https://www.ski.com/)
    > Ski is likely to be the most reputable winter sports planning site in existence today. They offer Epic passes, and every other winter sport accesory that anyone could ever need. Their process is more in depth than my project as they have the option of providing a "Mountain Travel Expert". They will help plan the absolute best experience making sure that nothing is missed or left out. Their home page allows the customer to search for the resort they would like to stay in. After selecting your resort and the dates, it then takes you to the results page where not only can you see the different offers at that resort, but you are paired with your own "Mountain Travel Expert". You can now contact this person and find out any details that could ever come across your mind. As you can imagine after inspecting I was able to find their custom CSS, JS, and their API sources that allows them to know more about your location or even meta data. This site although is the most popular, doesn't align with what im trying to exactly accomplish but gives a very good guide of what it should interact and look like in the end.


 **Complete GitHub Repository Research.**
  
1. [TravelYaari-react](https://github.com/shsarv/TravelYaari-react/tree/main)
    >TravelYaari-react is a free to use travel website that allows users to book trips to their favorite destinations, according to the problem statement it helps people all over the world find the best places to go. After looking at the source code I could tell that this project also has backend code that goes with it. It is acknowledged and linked in the README.md as well. This tells me this is a full project that is linked to some type of sql or nosql database. According to the type of data presumably being stored, I believe this would be a SQL server not nosql. Although there isn't much that I can literally take from this repository, the backend implementation will be a major help in the future of developing my backend. The best thing I learned so far from this repository is how to structure my overview in this README.md.
2. [Ridex](https://github.com/codewithsadee/ridex?tab=readme-ov-file)
    >Ridex is another free to use website, but instead of travel e-commerce; this is a vehicle e-commerce site. The reason for analyzing this site is the fact that the searchbar is exactly what I would like to make my searchbar look like in the future ( like [Carolina Cabin Rentals](https://www.carolinacabinrentals.com/)).I beleive this is my best example since it has no backend and only the very basic home page with very little JS. It also came in clutch for understanding how to manipulate custom css as well as bootstrap. 


 **Project overview**:
  
   - Project Summary

> Have you ever wanted to find the mountain with the most snow in the area? Or have you ever been a victim of a rainy snow/ski trip? That is no more! GeoSnow is the first weather guided e-commerce traveling site. Allowing users to find the resorts they love on the days they know will bring the best results. At this phase my site is a rudimentary starting point to what it could potentially be in the future. 
     
   - Page Descriptions

> As of current; I have 6 pages. The home page is where users can jump right into searching for resorts, or in our footer they can add themselves to our newsletter. Once a user searches a location to book a resort, they are redirected to our search results page. This is where they can see the list of resorts within the radius they selected. From here when users select a resort they want to look into further, they are redirected to our resort details page. This is where they can see all of the resort information, also on the page is the live-chat forum. This is where users can add a post and with the correct authorization delete a post. Below this is the weather by the hour, presented by the NOAA API. This information effectively allows users to navigate to resorts that have availability, make comments, delete them, as well as having the option to add themselves to our newsletter. If a user chooses they no longer want to be a part of our newsletter, they can use the quick link in our footer that redirects to our remove subscriber page. Form here they can enter in the email that they would like to remove and if it is in our database it will be removed. If a user has any questions about the use of their personal information they can use one of the quick links to navigate to our terms & conditions page. This is where they will find all of the relevant information pertaining to how their data is used and stored. If a user has any further questions, they can use either the contact us button at the end of the privacy notice or select the contact us quick link in the footer. This is our last page as of currently that displays all of our teams personal contact information incase anyone needs to communicate with the devs.
   - Research Overview

> Based on my research, I found that traveling sites or even regular e-commerce sites are a ton more reactive than they have ever been due to cshtml, css, and JS. Although we are learning the basics, due to the adoption of web3 and API's we are able to have more reactive sites than ever before, taking a 1/10th of the amount of work that it used to take to get similar results. I have also realized that almost all websites styles look similar since we all use bootstrap to make our lives easier. This is what makes web design faster for people who don't know how to make custom CSS.
   - Future Enhancements

> In the next phase of development I will be scaffolding Identity into my project in order to initialize the Identity Framework. This allows authorization between certain pages within the app. With this completed I will be able to finish the checkout and reservation pages needed in order to facilitate a fully functional booking site.

[**GeoSnow Web-App Prototype**](GeoSnowProposal.md)
## Deployment Guide
   - 1st steps
> Clone this repo

> Clone the repo linked under GeoSnow SQL Database
   - 2nd Steps (Assuming you have Server SQL Managment already installed)
> Open DatabaseCreation.sql in Server SQL and execute it along with all other .sql files

   - 3rd Steps
> Open configuration files and change the connection url's to local host

> In order to get database connection to frontend, proper configuration is needed
   - 4th Step
> Once all connections are established, its time to run, debug, and take off from where we left



## GeoSnow SQL Database
[**Database**](https://github.com/CollinJenkins0/MIST-353-001_GeoSnow.git)

For further API documentation check under MIST-353-002/GeoSnowAPI 

## Deployment Problems / Future Development Documentation
> use stack overflow and chat-gpt, goodluck lol

## References
 **Citations**:

>https://www.ski.com/: 1st website inspiration
>
>https://www.carolinacabinrentals.com/: 2nd website inspiration
>
>https://www.onthesnow.com/: 3rd website inspiration
>
>https://github.com/shsarv/TravelYaari-react/tree/main: 1st repository inspiration
>
>https://github.com/codewithsadee/ridex?tab=readme-ov-file: 2nd repository inspiration
>
>https://github.com/codewithsadee/tourest: Header, #about, and Footer
>
>https://github.com/joshuatmeadows/MIST353-TravelSite: Searchbar
>
>https://www.w3schools.com/bootstrap5/index.php: BS5 Table
>
>https://www.markdownguide.org/basic-syntax/: .md syntax help
>
>https://github.com/codewithsadee/tourest: Custom CSS that I altered in order to use WVU brand RGB 
>
>https://openai.com/chatgpt: used to help customize css for Searchbar; "make custom css to make my Searchbar 18px and explain what each element does to the style"

 **Reflection on Resources**:
 > I believe that the use of generative AI and other resources that help write code can be very useful, and also very hurtful. When using AI in order to learn, it is very helpful, but when its used to cheat and disregard work, that is when it gets hurtful. As the AI does everything, the user has zero clue what is actually going on and when it comes to real life, the concepts copied wont be able to be reproduced. I personally struggled when it came to trying to make my custom CSS and that is when Chat-GPT was useful as it explained what each element did to the style and broke it down step by step for me. I found great help in [w3schools](https://www.w3schools.com/bootstrap5/index.php) as they teach you line by line how to implement whatever function you need. All in all, finding the things I needed to incorporate into my project was very straight forward and easy.
