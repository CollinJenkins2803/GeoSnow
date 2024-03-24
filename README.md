MIST-353 Assignment 2: Prototype Development and Research for Web Application
 =============================================================================
 ![Nice Pic](https://valutrack.com/wp-content/uploads/2023/03/isa-cybersecurity-training-2-1.jpg)

For this assignment:

 **My Competitive Analysis**

1. [Carolina Cabin Rentals](https://www.carolinacabinrentals.com/)
    >Carolina Cabin Rentals is more of a local website meaning that they only provide data for resorts and cabin rentals in the states of North and South Carolina. This is a great inspiration to my project due to its interactive home page. this is what I would like my home page to reference as my development contuinues. During inspection of this site I was able to find their use of API's for their map. I was also able to find their custom CSS and bootstrap. I would like to replicate the resizing css that allows their page to be seen in different sizes. All in all, I would like to use this website as the crude basis for what my home page will eventually end up looking like.

2. [On The Snow](https://www.onthesnow.com/)
    > On The Snow provides customers with a user friendly experience that allows them to search for the resort or region they are looking for, while also providing a container that holds all of their most popular searches. This site offers snow reports so you can take a look at the snowfall for whatever resort you plan on going to. On the technical side of things, this site seems to use custom css as well as bootstrap 5. After inspecting I was able to see their use of API's in order to recieve the weather data provided to users. Overall this website is a great inspiration as it has all the requirements that I would like to include into my project.
    

3. [Ski](https://www.ski.com/)
    > Ski is likely to be the most reputable winter sports planning site in existence today. They offer Epic passes, and every other winter sport accesory that anyone could ever need. Their process is more in depth than my project as they have the option of providing a "Mountain Travel Expert". They will help plan the absolute best experience making sure that nothing is missed or left out. Their home page allows the customer to search for the resort they would like to stay in. After selecting your resort and the dates, it then takes you to the results page where not only can you see the different offers at that resort, but you are paired with your own "Mountain Travel Expert". You can now contact this person and find out any details that could ever come across your mind. As you can imagine after inspecting I was able to find their custom CSS, JS, and their API sources that allows them to know more about your location or even meta data. This site although is the most popular, doesn't align with what im trying to exactly accomplish but gives a very good guide of what it should interact and look like in the end.


 **Complete GitHub Repository Research.**
  
1. [TravelYaari-react](https://github.com/shsarv/TravelYaari-react/tree/main)
    >TravelYaari-react is a free to use travel website that allows users to book trips to their favorite destinations, according to the problem statement it helps people all over the world find the best places to go. After looking at the source code I could tell that this project also has backend code that goes with it. It is acknowledged and linked in the README.md as well. This tells me this is a full project that is linked to some type of sql or nosql database. According to the type of data presumably being stored, I believe this would be a SQL server not nosql. Although there isnt much that I can litterally take from this repository, the backend implementation will be a major help in the future of developing my backend. The best thing I learned so far from this repository is how to structure my overview in this README.md.
2. [Ridex](https://github.com/codewithsadee/ridex?tab=readme-ov-file)
    >Ridex is another free to use website, but instead of travel e-commerce; this is a vehicle e-commerce site. The reason for analyzing this site is the fact that the searchbar is exactly what I would like to make my searchbar look like in the future ( like [Carolina Cabin Rentals](https://www.carolinacabinrentals.com/)).I beleive this is my best example since it has no backend and only the very basic home page with very little JS. It also came in clutch for understanding how to manipulate custom css as well as bootstrap. 


 **Project overview**:
  
   - Project Summary

> Have you ever wanted to find the mountain with the most snow in the area? Or have you ever been a victim of a rainy snow/ski trip? That is no more! GeoSnow is the first weather guided e-commerce traveling site. Allowing users to find the resorts they love on the days they know will bring the best results. At this phase my site is a rudementary starting point to what it could potentially be in the future. As of right now my searchbar is non-functional as well as my other anchors. Everything that can be clicked will one day be fully functional.
     
   - Page Descriptions

> As of current; I have a "Home" page and a "ContactUs" page. The home page has my header, hero, searchbar, about, and footer. My ContactUs page consist of the same header and footer but as well as a bootstrap 5 table consisting of 2 rows. It contains the First, Last, and email of the current employees at GeoSnow Inc. I also have custom CSS that is displaying the WVU brand RGB in order to give my site a more professional look. I have only included some simple JS to my navbar which allows it to be used when the screen size is small enough. The only other JS I have so far is my searchbar which I used the class lectures code in order to construct.
   - Research Overview

> Based on my research, I found that traveling sites or even regualr e-commerce sites are a ton more reactive than they have ever been due to cshtml and JS. ALthough we are learning the basics, due to the adoption of web3 and new API's we are able to have more reactive sites than ever before, taking a 1/10th of the amount of work that it used to take to get similiar results. I have also realized that almost all websites styles look similar since we all use bootstrap to make our lives easier. This is what makes web design capable for people who dont know how to make custom CSS.
   - Future Enhancements

> In the next phase of development I will be adding a page for every anchor on my site. I also will be adding more JS in order to have a more capable site. The biggest fail I had on this current iteration that will be different next time is the incosistency in style from "Home" to "ContactUs". I also will be adding in some backend API calls in order to prevent end users getting my API key. I also am now considerding what sql server I will be linking to my application and how I would accomplish that.

[**GeoSnow Web-App Proposal**](\MIST-353-001\GeoSnowProposal.md)

## References
 **Citations**:

>https://www.ski.com/: 1st website inspiration
>
>https://www.carolinacabinrentals.com/: 2nd wesbite inspiration
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
 > I believe that the use of generative AI and other resources that help write code can be very useful, and also very hurtful. When using AI in order to learn, it is very helpful, but when its used to cheat and disregard work, that is when it gets hurtful. As the AI does everything, the user has zero clue what is actually going on and when it comes to real life, the concepts copied wont be able to be reproduced. I personally struggled when it came to trying to make my custom CSS and that is when Chat-GPT was useful as it explained what each element did to the style and broke it down step by step for me. I found great help in [w3schools](https://www.w3schools.com/bootstrap5/index.php) as they teach you line by line how to implement whatever function you need. All in all, finding the things I needed to incorporate into my project was very straight foward and easy.