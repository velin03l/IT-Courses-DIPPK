CREATE TABLE `cities`
(
	`id` INT(11) AUTO_INCREMENT PRIMARY KEY,
	`name` varchar(45) NOT NULL,
	`country_name` varchar(60) NOT NULL
); 

CREATE TABLE  `companies` 
(
	`id` INT(11) AUTO_INCREMENT PRIMARY KEY,
	`name` varchar(45) NOT NULL,
	`rate` INT(11) NOT NULL,
	`created_on` DATE NOT NULL 	
	
);
CREATE TABLE `building_types` 
(
	`id` INT(11) AUTO_INCREMENT PRIMARY KEY,
	`name` varchar(30) NOT NULL UNIQUE
); 
CREATE TABLE `persons` 
(
	`id` INT(11) AUTO_INCREMENT PRIMARY KEY,
	`username` varchar(30) NOT NULL UNIQUE,
    `company_id` INT(11),
    `city_id` INT(11),
    CONSTRAINT `fk_persons_companies` FOREIGN KEY(`company_id`) REFERENCES companies(id),
    CONSTRAINT `fk_persons_cities` FOREIGN KEY(`city_id`) REFERENCES cities(id)
);
CREATE TABLE `person_info` 
(
	`id` INT(11) AUTO_INCREMENT PRIMARY KEY,
	`first_name` varchar(60) NOT NULL,
    `last_name` varchar(60),
    `money` DECIMAL(15,2) DEFAULT 0,
    `person_id` INT(11) NOT NULL UNIQUE,
    CONSTRAINT `fk_personinfo_personid` FOREIGN KEY(`person_id`) REFERENCES persons(id)
    
);
CREATE TABLE  `buildings` 
(
	`id` INT(11) AUTO_INCREMENT PRIMARY KEY,
	`name` varchar(80) NOT NULL UNIQUE,
    `rent_amount` DECIMAL(17,2),
    `height` DECIMAL(15,2) NOT NULL,
    `floors` INT(11) ,
    `finished_year` INT(11) ,
    `status` varchar(50) NOT NULL,
    `city_id` INT(11) NOT NULL,
    `type_id` INT(11) NOT NULL,
    `company_id` INT(11) NOT NULL,
  CONSTRAINT `fk_buildings_city` FOREIGN KEY(`city_id`) REFERENCES cities(id), 
    CONSTRAINT `fk_buildings_type` FOREIGN KEY(`type_id`) REFERENCES building_types(id), 
      CONSTRAINT `fk_buildings_company` FOREIGN KEY(`company_id`) REFERENCES companies(id)
    
);
CREATE TABLE `persons_buildings` 
(
	`person_id` INT(11) NOT NULL,
	`building_id` INT(11) NOT NULL,
    CONSTRAINT `pk_building_types_types` PRIMARY KEY(`person_id`,`building_id`),
	CONSTRAINT `fk_building_types_plants` FOREIGN KEY(`person_id`) REFERENCES persons(id),
	CONSTRAINT `fk_building_types_orders` FOREIGN KEY(`building_id`) REFERENCES buildings(id)
);