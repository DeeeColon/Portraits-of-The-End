-> main

=== main ===
"Alright, end of the world, there must be someone in a bar" #Speaker:Charlie #choice:reset
"This is strange, it seems to be rather empty in here, I wonder why? "Maybe the bartender will know." #Speaker:Charlie
"Hey, sweetheart, can I get you anything?" #Speaker:Sienna #Portrait:SiennaNeutral
"Oh no, I don’t drink, but thank you" #Speaker:Charlie
"If you don’t drink, what brings you to my bar?" #Speaker:Sienna #Portrait:SiennaNeutral
"Well, I'm a journalist and I decided to spend my last few days doing what I love. I'm here looking for someone to interview." #Speaker:Charlie
"So umm… You said this was your bar, right? Why do you keep it open when it's so vacant?" #Speaker:Charlie
"Oh, so I guess I'm your interviewee, interesting choice." #Speaker:Sienna #Portrait:SiennaHappy
"Well, I keep the bar open not so much for me but for my people. I worry about them a lot." #Speaker:Sienna #Portrait:SiennaHappy
"What do you mean by 'your people?' "#Speaker:Charlie
"Okay, have you heard of  the Emerald Mafia, those mischievous trouble makers?" #Speaker:Sienna #Portrait:SiennaHappy
"Honestly, I just picked at random, tho seems I've lucked out, but yes, I know about them. Why do you bring it up?" #Speaker:Charlie
"Honestly, I just picked at random, though seems I've lucked out, but yes, I know about them. Why do you bring it up?" #Speaker:Charlie

"Well,l this bar is a known front for that mafia." #Speaker:Sienna #Portrait:SiennaHappy
"Wait, you said you own this bar…" #Speaker:Charlie
“Yes. And it's named after me, too. Do you understand where this is going?” #Speaker:Sienna #Portrait:SiennaNeutral
"So you are the boss, in more than one way…" #Speaker:Charlie
"Exactly, and a bloody good one at that." #Speaker:Sienna 
    +["Okay..Mafia. When I walked in, I didn't think that you would be a criminal."] 
        "You never know someone's story, as a journalist,t you should know better than to just judge someone." #Speaker:Sienna #Portrait:SiennaUpset #Choice:bad
        ->afterFirstChoice
    +["One complicated family you have, I can understand why it worries you."]
        “I wouldn't trade it for the world, though" #Portrait:SiennaNeutral
 #Choice:good #Speaker:Sienna #Portrait:SiennaNeutral
        “I never thought someone would talk so sweetly about a mafia gang."#Speaker:Charlie
        "I guess there is always some part of a person to love, even for ruffians and thugs." #Speaker:Charlie
        ->afterFirstChoice
    +["I can't lie, that’s very enticing."]
        “I'm enticing? That’s a new one, but given my job, I can't blame you for that."  #Choice:great #Speaker:Sienna #Portrait:SiennaHappy
        “A beautiful woman, as you know her value, why wouldn’t I wanna know more?" #Speaker:Charlie
        “Indeed, the complexity of your job already holds so much." #Speaker:Charlie
        “Well, my job is my life, for better or worse." #Speaker:Sienna #Portrait:SiennaNeutral
        “Look, you gotta make time for yourself, remember you are more than what you do." #Speaker:Charlie
        “I get it, your job makes you happy and it's obviously fulfilling, surrounded by people you care about. I don’t see anything wrong with that." #Speaker:Charlie

        ->afterFirstChoice
=== afterFirstChoice ===
"So, can I ask how you ended up in this situation?” #Speaker:Charlie 
“Well, when the Emerald City was still newly developing, my grandfather left Italy to live here, and he basically became a loan shark to make ends meet.”#Speaker:Sienna #Portrait:SiennaNeutral
“He grew a community like this and so became the Emerald Mafia.”#Speaker:Sienna #Portrait:SiennaNeutral
“Oh wow, so he really made something for himself” #Speaker:Charlie
“He had 3 sons and taught them the ins and outs of the business. After he passed, his eldest son took over, that being my dad.” #Speaker:Sienna #Portrait:SiennaNeutral
“Then it was my turn. My dad built me this bar, as a gift for my handover, called it Sienna's place.
“He built it in our favourite place in the city.” #Speaker:Sienna #Portrait:SiennaHappy

    +["So you guys are basically a family of criminals…" ]
        "I mean technically, but it's deeper than the law is neglectful of many people. So call us criminals for all I care, we exist for a reason." #Choice:bad #Speaker:Sienna #Portrait:SiennaUpset
        ->afterSecondChoice
    +["Ahhh, it's generational. So some of your reputation is carried by your name, the legacy of those before you." ]
        "I would agree with that sentiment, my father and his father made this life for me." #Speaker:Sienna #Choice:good #Portrait:SiennaHappy
      “Hey, it's not all of them, you have to carry that legacy, hold up to their standards." #Speaker:Charlie
      “I'm surprised at the amount of heart and love that can be found in a mafia gang, it's really a fresh perspective." #Speaker:Charlie
        ->afterSecondChoice
    +["Ah so a woman in power, that’s impressive, especially in this world run by men."]
        “I do pride myself that I'm not the most intimidating but yet my presence demands respect." #Speaker:Sienna #Choice:great #Portrait:SiennaHappy
        “I mean, come on, to hold authority like this in an environment like you have to be at least a little scary." #Speaker:Charlie
        “You should be proud, you are a beautiful woman who has done a lot." #Speaker:Charlie
        “You flatter me, but I'll take the compliments." #Speaker:Sienna #Portrait:SiennaHappy
        “Well, you are an easy person to compliment."#Speaker:Charlie
        ->afterSecondChoice
=== afterSecondChoice ===
"There is a lot of history here, tell me why this is your favourite place in the city.” #Speaker:Charlie
“Growing up, he really valued ‘us’ time, given his work.  So we would come here for picnics, it was my favourite place in the city.” #Speaker:Sienna #Portrait:SiennaHappy
“What a rare experience, in a job like that, to still make time for father-daughter time.” #Speaker:Charlie
“I mean, we are still human, we still have hearts” 
“Actually it kinda breaks my heart, but I think I'm going to close the bar” #Speaker:Sienna #Portrait:SiennaUpset
“Oh no, why would you do that?” #Speaker:Charlie
“Well, it's just me working now, and I can't manage by myself. The business is suffering for it, so I feel like I have no choice. Plus, what's the point with the end so close?”#Speaker:Sienna 
“No, you can't let the legacy die like this. Let me help you. I'm sure we can get it ready for customers again.” #Speaker:Charlie
“Then maybe you can host one last good night for a farewell.” #Speaker:Charlie
"Thanks for coming by sweetheart, its nice to chat with someon every once and a while" #Speaker:Sienna #Portrait:SiennaSad
"No problem, see you around!" #Speaker:Charlie



-> DONE
