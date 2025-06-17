“Hi there, sorry to interrupt. I’m a journalist, can I have a few minutes of your time #Speaker:Charlie #Choice:reset
 “Oh- hello, sure I can spare a few minutes.” #Speaker:Tobias #Portrait:TobiasNeutral
“Let me just make some space for you, I'll just move my laptop.” #Speaker:Tobias #Portrait:TobiasNeutral
“I'm surprised you’re still working. Thank you for making time for me. ” #Speaker:Charlie
“Oh, no worries, it’s not like it's the end of the world.” #Speaker:Tobias  
 "*chuckles* “You’re in high spirits about all this” #Speaker:Charlie
“I wouldn't really say high spirits, more like I’m trying not to focus on it.”  #Speaker:Tobias #Portrait:TobiasUpset
“Is that the reason you are still working?” #Speaker:Charlie
“Kinda, I guess, I’ve just been working my entire life and have nothing else to do.” #Speaker:Tobias 
“Well, I understand that, I'm sort of in the same position. 
My work is my life, and for these last few days, I'm gonna spend it doing what I love, what I'm good at.”  #Speaker:Charlie 
“I wouldn’t necessarily say it's what I love, but I think it's safe to say I'm good at it.” #Speaker:Tobias  #Portrait:TobiasNeutral
“Wait, why do you do it then, don't you have hobbies or loved ones to spend time with?”#Speaker:Charlie
“ I never really cared much for hobbies and for ‘loved ones’.”
“ I don't have a relationship with them anymore.” #Speaker:Tobias Portrait:TobiasUpset
->choiceOne
=== choiceOne ==
"Let's talk about..." #Speaker:Charlie
* [Ask about Hobbies]
    “So you never thought to take a break by doing something less than working?” #Speaker:Charlie
    “I mean sure, everyone has thought about that stuff at one stage in their life but I’ve just lost that kinda urge.” #Speaker:Tobias
        ->choiceOneA
        ===choiceOneA===
        * [“That sounds really sad”] 
            “That a little rude, this is my life you're calling sad” #Speaker:Tobias #Portrait:TobiasUpset #Choice:bad
        ->choiceOne
        
        
        * [“I understand that”] 
            “Its just how it goes when life gets in the way” #Speaker:Tobias #Choice:good
            “Well, yes, but that's only if you let it” #Speaker:Charlie
            ->choiceOne
        
        
        *["That's unfortunate. Well, what were you used to be interested in?”]
            “I used to like feeding the ducks in the park, simple, but it was calming, like I was in a different world. ” #Speaker:Tobias #Portrait:TobiasHappy #Choice:great
            “That is… very surprising, but I get it.” #Speaker:Charlie
            “I think I envy these carefree ducks as odd as that sounds.” #Speaker:Tobias 
            ->choiceOneB
            ===choiceOneB===
             *[“Oh, to be a duck in a pond.”] #Speaker:Charlie
             ->afterFirstChoice
             *[“Odd if you wanna be a duck, but wanting to be carefree, that's human.”] #Speaker:Charlie
             ->afterFirstChoice
             

    ->choiceOne
===afterFirstChoice===
* [Ask about Loved Ones]
    “Wait, but your laptop screen… I thought those were your parents on the home screen. If you aren't close, why have that? #Speaker:Charlie
    “That's slightly invasive, but if you must know, the relationship is… complicated”  #Speaker:Tobias
    ->choiceTwo
    
===choiceTwo===
*["Well, I’m a journalist it's kinda my job to be intrusive"]
    “Yeah, but I'm not some big scoop, I’m just a person, and I don't appreciate it” #Speaker:Tobias #Portrait:TobiasUpset #Choice:bad


    
->afterSecondChoice
    
*[“Oh, interesting, how so?”]
    “Um, ok… I guess they expect more from me, and I can give it to them.” #Speaker:Tobias #Choice:good
    “Ah, strict parents. Makes sense.” #Speaker:Charlie

->afterSecondChoice
    
*[“Oh, I'm so sorry I didn’t mean to intrude, they just caught my eye. Do you mind telling me a little bit about them?”]
    “Don’t worry about it, and since you asked, sure.” #Speaker:Tobias #Portrait:TobiasNeutral #Choice:Great
“I have the typical Indian parents, they expect the best from me and nothing short. 
I’m supposed to dedicate myself to my work, which I have, but I'm still not good enough.”
“So, although all I want to do is make them proud, I don't really enjoy talking with them.” #Speaker:Tobias
->afterSecondChoice
    
===afterSecondChoice===
“You really have a lot going on, you deserve time for yourself to just be.”#Speaker:Charlie
“I wouldn’t even know what to do with myself.”#Speaker:Tobias #Portrait:TobiasUpset
"But thank you for coming to talk with me, it's been some time since I got to just chat." #Portrait:TobiasHappy
"Sure, any time!"#Speaker:Charlie

->END
