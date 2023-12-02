-- phpMyAdmin SQL Dump
-- version 4.9.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Mar 01, 2023 at 01:22 PM
-- Server version: 10.3.25-MariaDB-0+deb10u1
-- PHP Version: 5.6.36-0+deb8u1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_boot_shop`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `id` int(255) NOT NULL,
  `username` varchar(255) COLLATE utf8_czech_ci NOT NULL,
  `password` varchar(255) COLLATE utf8_czech_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `username`, `password`) VALUES
(1, 'JackHerrer', '123456'),
(2, 'JanBongzhulil', '420'),
(3, 'JosefKýblstočil', '420');

-- --------------------------------------------------------

--
-- Table structure for table `brand`
--

CREATE TABLE `brand` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `logo_filename` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `brand`
--

INSERT INTO `brand` (`id`, `name`, `logo_filename`) VALUES
(1, 'Bundgaard', 'test'),
(2, 'adidas', 'adidas');

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`id`, `name`) VALUES
(10, 'kuthwerputzwerpuzt'),
(11, 'boty'),
(12, 'Ahoj'),
(13, 'DetskeBoty');

-- --------------------------------------------------------

--
-- Table structure for table `color`
--

CREATE TABLE `color` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `hex_code` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `color`
--

INSERT INTO `color` (`id`, `name`, `hex_code`) VALUES
(10, 'modrá', '#004080'),
(11, 'zelená', '#008000'),
(14, 'bílá', '#ffffff'),
(15, 'modrý', '#004000'),
(16, 'ČERVENÁ', '#cc0005');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `id` int(11) NOT NULL,
  `customer_name` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `customer_surname` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `customer_town` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `customer_zipcode` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `customer_phone` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `customer_email` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `customer_address` varchar(255) COLLATE utf8_czech_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`id`, `customer_name`, `customer_surname`, `customer_town`, `customer_zipcode`, `customer_phone`, `customer_email`, `customer_address`) VALUES
(1, 'ahoj', 'ahoj', 'ahoj', '123456', '123456789', 'ahoj', 'ahoj'),
(2, 'ahoj', 'ahoj', 'ahoj', '123456', '123456789', 'ahoj', 'ahoj'),
(3, 'ahoj', 'ahoj', 'ahoj', '123456', '123456789', 'ahoj', 'ahoj'),
(4, 'ahoj', 'ahoj', 'ahoj', '123456', '123456789', 'ahoj', 'ahoj'),
(5, 'ahoj', 'ahoj', 'ahoj', '11100', '123456789', 'ahoj', 'ahoj'),
(6, 'ahoj', 'ahoj', 'ahoj', '11100', '123456789', 'ahoj', 'ahoj'),
(7, 'ahoj', 'ahoj', 'ahoj', '11100', '123456789', 'ahoj', 'ahoj'),
(8, 'ahoj', 'ahoj', 'ahoj', '11100', '123456789', 'ahoj', 'ahoj'),
(9, 'ahoj', 'ahoj', 'ahoj', '11100', '123456789', 'ahoj', 'ahoj'),
(10, 'ahoj', 'ahoj', 'ahoj', '123456', 'ahoj', 'ahoj', 'ahoj'),
(11, 'ahoj', 'ahoj', 'ahoj', '11100', 'ahoj', 'ahoj', 'ahoj'),
(12, 'Bohdan', 'Duda', 'ahoj', '41201', '123456789', 'ahoj', 'ahoj'),
(13, 'ahoj', 'ahoj', 'ahoj', '41201', 'ahoj', 'ahoj', 'cigan');

-- --------------------------------------------------------

--
-- Table structure for table `delivery_method`
--

CREATE TABLE `delivery_method` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `delivery_method`
--

INSERT INTO `delivery_method` (`id`, `name`, `price`) VALUES
(1, 'PPL', 100.00),
(2, 'Zásilkovna', 65.00),
(3, 'Česká Pošta', 90.00);

-- --------------------------------------------------------

--
-- Table structure for table `newsletter_recipient`
--

CREATE TABLE `newsletter_recipient` (
  `id` int(11) NOT NULL,
  `email` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `id` int(11) NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `total_price` decimal(10,2) DEFAULT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `delivery_method_id` int(11) DEFAULT NULL,
  `payment_method_id` int(11) DEFAULT NULL,
  `note` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`id`, `created_at`, `total_price`, `customer_id`, `delivery_method_id`, `payment_method_id`, `note`) VALUES
(1, '2023-01-23 19:46:01', 50.00, 1, 1, 1, NULL),
(2, '2023-01-23 19:47:02', 50.00, 2, 1, 1, NULL),
(3, '2023-01-23 19:47:11', 50.00, 3, 1, 1, NULL),
(4, '2023-01-23 19:47:17', 50.00, 4, 1, 1, NULL),
(5, '2023-01-23 20:07:18', 207.00, 5, 2, 3, NULL),
(6, '2023-01-23 20:10:27', 207.00, 6, 3, 4, NULL),
(7, '2023-01-23 20:11:23', 1743.00, 7, 2, 1, NULL),
(8, '2023-01-23 20:13:00', 1743.00, 8, 2, 1, NULL),
(9, '2023-01-23 20:13:33', 1743.00, 9, 3, 1, NULL),
(10, '2023-01-23 20:18:23', 1494.00, 10, 1, 4, NULL),
(11, '2023-01-23 20:45:22', 2841.00, 11, 1, 4, NULL),
(12, '2023-01-30 07:20:03', 840.00, 12, 1, 3, NULL),
(13, '2023-02-04 15:01:50', 500.00, 13, 2, 4, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `order_item`
--

CREATE TABLE `order_item` (
  `id` int(11) NOT NULL,
  `product_variant_id` int(11) DEFAULT NULL,
  `order_id` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `unit_price` decimal(10,2) DEFAULT NULL,
  `total_price` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `order_item`
--

INSERT INTO `order_item` (`id`, `product_variant_id`, `order_id`, `quantity`, `unit_price`, `total_price`) VALUES
(1, 12, 1, 2, 25.00, 50.00),
(2, 12, 2, 2, 25.00, 50.00),
(3, 12, 3, 2, 25.00, 50.00),
(4, 12, 4, 2, 25.00, 50.00),
(5, 8, 5, 3, 69.00, 207.00),
(6, 8, 6, 3, 581.00, 207.00),
(7, 8, 7, 3, 581.00, 1743.00),
(8, 8, 8, 3, 581.00, 1743.00),
(9, 8, 9, 3, 581.00, 1743.00),
(10, 2, 10, 3, 498.00, 1494.00),
(11, 7, 11, 2, 500.00, 1000.00),
(12, 11, 11, 3, 420.00, 1260.00),
(13, 8, 11, 1, 581.00, 581.00),
(14, 11, 12, 2, 420.00, 840.00),
(15, 7, 13, 1, 500.00, 500.00);

-- --------------------------------------------------------

--
-- Table structure for table `payment_method`
--

CREATE TABLE `payment_method` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `payment_method`
--

INSERT INTO `payment_method` (`id`, `name`) VALUES
(1, 'Dobírka'),
(2, 'Platba kartou'),
(3, 'Bankovním převodem'),
(4, 'Kryptoměna');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `brand_id` int(11) DEFAULT NULL,
  `category_id` int(11) DEFAULT NULL,
  `subcategory_id` int(11) DEFAULT NULL,
  `summary` varchar(4000) COLLATE utf8_czech_ci DEFAULT NULL,
  `description` varchar(4000) COLLATE utf8_czech_ci DEFAULT NULL,
  `code` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `type` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `material` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `purpose` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `primary_image_filename` varchar(255) COLLATE utf8_czech_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`id`, `name`, `brand_id`, `category_id`, `subcategory_id`, `summary`, `description`, `code`, `type`, `material`, `purpose`, `primary_image_filename`) VALUES
(1, 'Benjamin Velcro Dark Grey', 1, 10, 7, 'uj', 'iii', 'BG004-001', 'Do deště, turistické', 'Guma', 'Chlapecké', 'bota1.png'),
(8, 'Netlačící boty s vysokou špičkou', 1, 10, 7, 'test', 'test', '987654', 'druh', 'materiál', 'určení', 'averageProgrammer.jpg'),
(9, 'Sandálky modré umělé', 2, 10, 7, 'test', 'test', 'test', 'test', 'test', 'test', 'bota3.png'),
(10, 'Bota', 2, 10, 7, 'Lorem', 'Ipsum', '123456', 'Sit', 'Amet', 'Dolor', 'bota2.png'),
(11, 'HezkaBota', 1, 11, 8, 'Lorem', 'Ipsum', '123456', 'akjhfakjlh', 'askljfhakj', 'asidhijh', 'averageProgrammer.jpg'),
(12, 'bota', 2, 12, 8, 'ans dkh', 'kkjabskjakjn', 'adfkjhalkjh', 'kkjsdfjlbabd', 'kjbalkdflka', 'kjafkakjnd', 'bota3.png'),
(13, 'ArnoldBota', 2, 12, 9, 'lorem', 'ipsum', '123456', 'sit', 'amet', 'dolor', 'arnold.jpg'),
(14, 'Kosik', 2, 13, 10, 'Ahoj', 'Ahoj', '42069', 'ahoj', 'latka', 'detske', 'C:\\Users\\dudab\\Pictures\\Screenshots\\Lorem.PNG');

-- --------------------------------------------------------

--
-- Table structure for table `product_photo`
--

CREATE TABLE `product_photo` (
  `id` int(11) NOT NULL,
  `product_id` int(11) DEFAULT NULL,
  `filename` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `is_primary` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `product_photo`
--

INSERT INTO `product_photo` (`id`, `product_id`, `filename`, `is_primary`) VALUES
(1, 13, 'arnold.jpg', NULL),
(2, 11, 'averageProgrammer.jpg', NULL),
(6, 13, 'bota1.png', NULL),
(7, 13, 'bota2.png', NULL),
(8, 13, 'bota3.png', NULL),
(9, 13, 'bota4.png', NULL),
(11, 11, 'GRIZZLY.jfif', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `product_variant`
--

CREATE TABLE `product_variant` (
  `id` int(11) NOT NULL,
  `product_id` int(11) DEFAULT NULL,
  `color_id` int(11) DEFAULT NULL,
  `size_id` int(11) DEFAULT NULL,
  `remaining_stock` int(11) DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `price_discount` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `product_variant`
--

INSERT INTO `product_variant` (`id`, `product_id`, `color_id`, `size_id`, `remaining_stock`, `price`, `price_discount`) VALUES
(1, 1, 10, 12, 10, 699.00, 579.00),
(2, 1, 11, 12, 0, 103.00, 498.00),
(6, 1, 10, 12, 2, 100.00, 50.00),
(7, 11, 14, 25, 2, 420.00, 500.00),
(8, 12, 10, 25, 2, 69.00, 581.00),
(9, 13, 15, 24, 12, 421.00, 420.00),
(10, 13, 11, 12, 12, 25.00, 65.00),
(11, 13, 15, 25, 7, 421.00, 420.00),
(12, 13, 11, 25, 12, 25.00, 65.00);

-- --------------------------------------------------------

--
-- Table structure for table `size`
--

CREATE TABLE `size` (
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `size`
--

INSERT INTO `size` (`id`) VALUES
(12),
(23),
(24),
(25),
(420);

-- --------------------------------------------------------

--
-- Table structure for table `subcategory`
--

CREATE TABLE `subcategory` (
  `id` int(11) NOT NULL,
  `name` varchar(255) COLLATE utf8_czech_ci DEFAULT NULL,
  `category_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Dumping data for table `subcategory`
--

INSERT INTO `subcategory` (`id`, `name`, `category_id`) VALUES
(7, 'as', 10),
(8, 'kožené', 11),
(9, 'cau', 12),
(10, 'do přírody', 13);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `brand`
--
ALTER TABLE `brand`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `color`
--
ALTER TABLE `color`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `delivery_method`
--
ALTER TABLE `delivery_method`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `newsletter_recipient`
--
ALTER TABLE `newsletter_recipient`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`id`),
  ADD KEY `customer_id` (`customer_id`),
  ADD KEY `delivery_method_id` (`delivery_method_id`),
  ADD KEY `payment_method_id` (`payment_method_id`);

--
-- Indexes for table `order_item`
--
ALTER TABLE `order_item`
  ADD PRIMARY KEY (`id`),
  ADD KEY `product_variant_id` (`product_variant_id`),
  ADD KEY `order_id` (`order_id`);

--
-- Indexes for table `payment_method`
--
ALTER TABLE `payment_method`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`),
  ADD KEY `brand_id` (`brand_id`),
  ADD KEY `category_id` (`category_id`),
  ADD KEY `subcategory_id` (`subcategory_id`);

--
-- Indexes for table `product_photo`
--
ALTER TABLE `product_photo`
  ADD PRIMARY KEY (`id`),
  ADD KEY `product_id` (`product_id`);

--
-- Indexes for table `product_variant`
--
ALTER TABLE `product_variant`
  ADD PRIMARY KEY (`id`),
  ADD KEY `product_id` (`product_id`),
  ADD KEY `color_id` (`color_id`),
  ADD KEY `size_id` (`size_id`);

--
-- Indexes for table `size`
--
ALTER TABLE `size`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `subcategory`
--
ALTER TABLE `subcategory`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_category_id` (`category_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `brand`
--
ALTER TABLE `brand`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `color`
--
ALTER TABLE `color`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `delivery_method`
--
ALTER TABLE `delivery_method`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `newsletter_recipient`
--
ALTER TABLE `newsletter_recipient`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `order`
--
ALTER TABLE `order`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `order_item`
--
ALTER TABLE `order_item`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `payment_method`
--
ALTER TABLE `payment_method`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `product_photo`
--
ALTER TABLE `product_photo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `product_variant`
--
ALTER TABLE `product_variant`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `subcategory`
--
ALTER TABLE `subcategory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`id`),
  ADD CONSTRAINT `order_ibfk_2` FOREIGN KEY (`delivery_method_id`) REFERENCES `delivery_method` (`id`),
  ADD CONSTRAINT `order_ibfk_3` FOREIGN KEY (`payment_method_id`) REFERENCES `payment_method` (`id`);

--
-- Constraints for table `order_item`
--
ALTER TABLE `order_item`
  ADD CONSTRAINT `order_item_ibfk_1` FOREIGN KEY (`product_variant_id`) REFERENCES `product_variant` (`id`),
  ADD CONSTRAINT `order_item_ibfk_2` FOREIGN KEY (`order_id`) REFERENCES `order` (`id`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`brand_id`) REFERENCES `brand` (`id`),
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`category_id`) REFERENCES `category` (`id`),
  ADD CONSTRAINT `product_ibfk_3` FOREIGN KEY (`subcategory_id`) REFERENCES `subcategory` (`id`);

--
-- Constraints for table `product_photo`
--
ALTER TABLE `product_photo`
  ADD CONSTRAINT `product_photo_ibfk_1` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`);

--
-- Constraints for table `product_variant`
--
ALTER TABLE `product_variant`
  ADD CONSTRAINT `product_variant_ibfk_1` FOREIGN KEY (`product_id`) REFERENCES `product` (`id`),
  ADD CONSTRAINT `product_variant_ibfk_2` FOREIGN KEY (`color_id`) REFERENCES `color` (`id`),
  ADD CONSTRAINT `product_variant_ibfk_3` FOREIGN KEY (`size_id`) REFERENCES `size` (`id`);

--
-- Constraints for table `subcategory`
--
ALTER TABLE `subcategory`
  ADD CONSTRAINT `FK_category_id` FOREIGN KEY (`category_id`) REFERENCES `category` (`id`),
  ADD CONSTRAINT `subcategory_ibfk_1` FOREIGN KEY (`category_id`) REFERENCES `category` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
