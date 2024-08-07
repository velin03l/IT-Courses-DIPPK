proizv fact = 
        if fact == 1
        then 1
        else fact*(proizv (fact - 1))

main = do
    line1 <- getLine 
    line2 <- getLine 
    let a = read line1 :: Int
    let b = read line2 :: Int

    if a <= 2 && b <= 1
        then putStrLn (show(1))
        else putStrLn(show(proizv b))

