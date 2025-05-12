-> main


=== main ===
Yo
This is test dialogue
Say something cool
    + [Yessir]
        That's so cool!
        -> afterChoiceOne
    + [No sir, thats lame]
        You're no fun
        ->afterChoiceOne
    + [You a weirdo]
        You're no fun
        ->afterChoiceOne

=== afterChoiceOne ===        
This should be the end tho?
yeah it is, bye bye!
-> END