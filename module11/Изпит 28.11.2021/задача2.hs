replicationList list1 broi = replicationList1 list1 [] broi 1

replicationList1 :: [a] -> [a] -> Int -> Int -> [a]
replicationList1 list1 list2 br broqch = 
    if br == 0
        then list2
        else if broqch <= br
            then ((head list1) : list2) ++ (replicationList1 list1 list2 br (broqch + 1))
            else (replicationList1 list1 list2 (br-1) 1)

main = do
    line1 <- getLine 
    line2 <- getLine 
    let a = read line1 :: Int
    print(replicationList line2 a)