BEGIN
    SET targetNumber TO random number between 1 and 100 
    SET guess TO -1
    WHILE guess IS NOT EQUAL TO targetNumber
        PRINT "Enter your guess (between 1 and 100):"
        READ guess
        IF guess < targetNumber THEN
            PRINT "Too low! Try again."
        Else IF guess > targetNumber THEN
        PRINT "Too high! Try again. "
        ELSE
            PRINT "Congratulations! You guessed the correct number."
        END IF
    END WHILE
END