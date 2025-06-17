-> main

=== main ===
Yo #Speaker:mah boy #Portrait:mehface
This is test dialogue 
-> choiceOne
=== choiceOne===
Say something cool
    + [Yessir]
        That's so cool! #Portrait:happyface #Choice:great
        -> afterChoiceOne
    + [No sir, thats lame]
        You're no fun #Portrait:sadface #Choice:bad 
        ->afterChoiceOne
    + [You a weirdo]
        You're no fun #Portrait:mehface #Choice:bad
        ->afterChoiceOne
-> choiceOne
=== afterChoiceOne ===        
This should be the end tho? #Portrait:mehface
    + [no it isn't]
        You are lying! #Portrait:sadface
        -> afterChoiceTwo
    + [yes it is]
        thanks man! #Portrait:happyface #Choice:good
        -> afterChoiceTwo
-> afterChoiceOne        
=== afterChoiceTwo ===
this is the end #Portrait:mehface
bye bye! #Portrait:happyface
-> END