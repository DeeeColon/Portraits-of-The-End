-> main


=== main ===
Yo 
This is test dialogue #speaker:mah boy #portrait:mehface
-> choiceOne
=== choiceOne===
Say something cool
    + [Yessir]
        That's so cool! #portrait:happyface
        -> afterChoiceOne
    + [No sir, thats lame]
        You're no fun #portrait:sadface
        ->afterChoiceOne
    + [You a weirdo]
        You're no fun #portrait:sadface
        ->afterChoiceOne
-> choiceOne
=== afterChoiceOne ===        
This should be the end tho? #portrait:mehface
    + [no it isn't]
        You are lying! #portrait:sadface
        -> afterChoiceTwo
    + [yes it is]
        thanks man! #portrait:happyface
        -> afterChoiceTwo
-> afterChoiceOne        
=== afterChoiceTwo ===
this is the end #portrait:mehface
bye bye! #portrait:happyface
-> END