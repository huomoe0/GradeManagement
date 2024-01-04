/*
 Navicat Premium Data Transfer

 Source Server         : mysql
 Source Server Type    : MySQL
 Source Server Version : 80035
 Source Host           : localhost:3306
 Source Schema         : grade_management

 Target Server Type    : MySQL
 Target Server Version : 80035
 File Encoding         : 65001

 Date: 01/01/2024 22:56:02
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for tb_class
-- ----------------------------
DROP TABLE IF EXISTS `tb_class`;
CREATE TABLE `tb_class`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `depart` int NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  INDEX `depart_class_foreignkey`(`depart` ASC) USING BTREE,
  CONSTRAINT `depart_class_foreignkey` FOREIGN KEY (`depart`) REFERENCES `tb_college` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 14 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_class
-- ----------------------------
INSERT INTO `tb_class` VALUES (1, '信息工程1班', 1);
INSERT INTO `tb_class` VALUES (2, '信息工程2班', 1);
INSERT INTO `tb_class` VALUES (3, '机电工程1班', 2);
INSERT INTO `tb_class` VALUES (4, '机电工程2班', 2);
INSERT INTO `tb_class` VALUES (5, '通讯工程1班', 3);
INSERT INTO `tb_class` VALUES (6, '通讯工程2班', 3);
INSERT INTO `tb_class` VALUES (7, '机械与自动化1班', 4);
INSERT INTO `tb_class` VALUES (8, '机械与自动化2班', 4);
INSERT INTO `tb_class` VALUES (9, '土木工程1班', 5);
INSERT INTO `tb_class` VALUES (10, '土木工程2班', 5);

-- ----------------------------
-- Table structure for tb_college
-- ----------------------------
DROP TABLE IF EXISTS `tb_college`;
CREATE TABLE `tb_college`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_college
-- ----------------------------
INSERT INTO `tb_college` VALUES (1, '信息工程学院');
INSERT INTO `tb_college` VALUES (2, '机电工程学院');
INSERT INTO `tb_college` VALUES (3, '通讯工程学院');
INSERT INTO `tb_college` VALUES (4, '机械与自动化学院');
INSERT INTO `tb_college` VALUES (5, '土木工程学院');

-- ----------------------------
-- Table structure for tb_course
-- ----------------------------
DROP TABLE IF EXISTS `tb_course`;
CREATE TABLE `tb_course`  (
  `cid` int NOT NULL AUTO_INCREMENT,
  `cname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`cid`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 5 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_course
-- ----------------------------
INSERT INTO `tb_course` VALUES (1, '高等数学');
INSERT INTO `tb_course` VALUES (2, '线性代数');
INSERT INTO `tb_course` VALUES (3, '计算机网络原理');
INSERT INTO `tb_course` VALUES (4, '计算机组成原理');

-- ----------------------------
-- Table structure for tb_grade
-- ----------------------------
DROP TABLE IF EXISTS `tb_grade`;
CREATE TABLE `tb_grade`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `stuid` int NOT NULL,
  `cid` int NOT NULL,
  `score` smallint NULL DEFAULT NULL,
  `term` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  UNIQUE INDEX `grade`(`stuid` ASC, `cid` ASC, `term` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 107 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_grade
-- ----------------------------
INSERT INTO `tb_grade` VALUES (19, 1315, 1, 3, '1');
INSERT INTO `tb_grade` VALUES (20, 1624, 1, 1, '1');
INSERT INTO `tb_grade` VALUES (21, 1801, 1, 1, '1');
INSERT INTO `tb_grade` VALUES (22, 1621, 1, 1, '1');
INSERT INTO `tb_grade` VALUES (23, 1869, 1, 1, '1');
INSERT INTO `tb_grade` VALUES (24, 1959, 1, 1, '1');
INSERT INTO `tb_grade` VALUES (25, 1710, 1, 1, '1');
INSERT INTO `tb_grade` VALUES (26, 1439, 1, 1, '1');
INSERT INTO `tb_grade` VALUES (27, 1737, 1, 1, '1');
INSERT INTO `tb_grade` VALUES (125, 1315, 1, 3, '2');
INSERT INTO `tb_grade` VALUES (126, 1624, 1, 1, '2');
INSERT INTO `tb_grade` VALUES (127, 1801, 1, 1, '2');
INSERT INTO `tb_grade` VALUES (128, 1621, 1, 1, '2');
INSERT INTO `tb_grade` VALUES (129, 1869, 1, 1, '2');
INSERT INTO `tb_grade` VALUES (130, 1959, 1, 1, '2');
INSERT INTO `tb_grade` VALUES (131, 1710, 1, 1, '2');
INSERT INTO `tb_grade` VALUES (132, 1439, 1, 1, '2');
INSERT INTO `tb_grade` VALUES (133, 1737, 1, 1, '2');

-- ----------------------------
-- Table structure for tb_student
-- ----------------------------
DROP TABLE IF EXISTS `tb_student`;
CREATE TABLE `tb_student`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `stuid` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `name` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `gender` char(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `politics` tinyint NULL DEFAULT NULL,
  `age` tinyint NULL DEFAULT NULL,
  `location` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `class` int NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  UNIQUE INDEX `stuid`(`stuid` ASC) USING BTREE,
  INDEX `stu_class_foreignkey`(`class` ASC) USING BTREE,
  CONSTRAINT `stu_class_foreignkey` FOREIGN KEY (`class`) REFERENCES `tb_class` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB AUTO_INCREMENT = 110 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_student
-- ----------------------------
INSERT INTO `tb_student` VALUES (3, '1735', '龙晓明', 'M', 3, 18, '上海市', 7);
INSERT INTO `tb_student` VALUES (4, '1610', '苏嘉伦', 'M', 2, 26, '北京市', 8);
INSERT INTO `tb_student` VALUES (5, '1669', '吴杰宏', 'M', 2, 17, '成都市', 10);
INSERT INTO `tb_student` VALUES (6, '1975', '吕睿', 'M', 1, 25, '东莞', 3);
INSERT INTO `tb_student` VALUES (7, '1039', '薛詩涵', 'F', 0, 18, '广州市', 10);
INSERT INTO `tb_student` VALUES (8, '1338', '陶晓明', 'M', 2, 29, '东莞', 7);
INSERT INTO `tb_student` VALUES (9, '1315', '钱晓明', 'M', 1, 22, '上海市', 1);
INSERT INTO `tb_student` VALUES (10, '1342', '崔杰宏', 'M', 2, 28, '上海市', 2);
INSERT INTO `tb_student` VALUES (11, '1205', '秦晓明', 'M', 3, 24, '广州市', 4);
INSERT INTO `tb_student` VALUES (12, '1490', '潘云熙', 'M', 1, 25, '东莞', 8);
INSERT INTO `tb_student` VALUES (13, '1897', '方晓明', 'M', 1, 25, '成都市', 6);
INSERT INTO `tb_student` VALUES (14, '1521', '朱秀英', 'F', 3, 22, '中山', 5);
INSERT INTO `tb_student` VALUES (15, '1624', '段安琪', 'F', 1, 15, '广州市', 1);
INSERT INTO `tb_student` VALUES (16, '1870', '孔嘉伦', 'M', 1, 16, '北京市', 2);
INSERT INTO `tb_student` VALUES (17, '1567', '史晓明', 'M', 0, 18, '成都市', 9);
INSERT INTO `tb_student` VALUES (18, '1478', '张安琪', 'F', 2, 20, '东莞', 9);
INSERT INTO `tb_student` VALUES (19, '1186', '薛子异', 'M', 2, 21, '北京市', 6);
INSERT INTO `tb_student` VALUES (20, '1685', '熊嘉伦', 'M', 1, 20, '中山', 10);
INSERT INTO `tb_student` VALUES (21, '1058', '杨嘉伦', 'M', 0, 24, '东莞', 7);
INSERT INTO `tb_student` VALUES (22, '1786', '莫致远', 'M', 2, 18, '广州市', 5);
INSERT INTO `tb_student` VALUES (23, '1901', '范睿', 'M', 2, 23, '广州市', 9);
INSERT INTO `tb_student` VALUES (24, '1312', '田杰宏', 'M', 1, 16, '深圳', 10);
INSERT INTO `tb_student` VALUES (25, '1592', '夏宇宁', 'M', 2, 20, '深圳', 5);
INSERT INTO `tb_student` VALUES (26, '1700', '韦璐', 'F', 2, 21, '深圳', 9);
INSERT INTO `tb_student` VALUES (27, '1446', '韩子异', 'M', 1, 19, '上海市', 5);
INSERT INTO `tb_student` VALUES (28, '1113', '魏晓明', 'M', 0, 23, '北京市', 5);
INSERT INTO `tb_student` VALUES (29, '1801', '谢嘉伦', 'M', 1, 25, '上海市', 1);
INSERT INTO `tb_student` VALUES (30, '1730', '曹秀英', 'F', 0, 30, '东莞', 8);
INSERT INTO `tb_student` VALUES (31, '1709', '徐安琪', 'F', 2, 23, '深圳', 10);
INSERT INTO `tb_student` VALUES (32, '1425', '戴岚', 'F', 1, 15, '北京市', 4);
INSERT INTO `tb_student` VALUES (33, '1471', '毛安琪', 'F', 2, 27, '东莞', 5);
INSERT INTO `tb_student` VALUES (34, '1609', '崔秀英', 'F', 2, 20, '北京市', 7);
INSERT INTO `tb_student` VALUES (35, '1698', '姜致远', 'M', 3, 15, '深圳', 4);
INSERT INTO `tb_student` VALUES (36, '1265', '唐宇宁', 'M', 2, 22, '中山', 9);
INSERT INTO `tb_student` VALUES (37, '1599', '史子异', 'M', 3, 23, '北京市', 3);
INSERT INTO `tb_student` VALUES (38, '1722', '胡杰宏', 'M', 2, 27, '深圳', 2);
INSERT INTO `tb_student` VALUES (39, '1523', '于子异', 'M', 3, 19, '广州市', 9);
INSERT INTO `tb_student` VALUES (40, '1811', '郝秀英', 'F', 3, 14, '中山', 7);
INSERT INTO `tb_student` VALUES (41, '1994', '莫睿', 'M', 1, 18, '上海市', 9);
INSERT INTO `tb_student` VALUES (42, '1475', '廖杰宏', 'M', 0, 28, '东莞', 7);
INSERT INTO `tb_student` VALUES (43, '1168', '何詩涵', 'F', 1, 24, '上海市', 7);
INSERT INTO `tb_student` VALUES (44, '1668', '侯璐', 'F', 1, 17, '东莞', 8);
INSERT INTO `tb_student` VALUES (45, '1123', '邱致远', 'M', 1, 28, '深圳', 4);
INSERT INTO `tb_student` VALUES (46, '1878', '姚璐', 'F', 2, 23, '成都市', 10);
INSERT INTO `tb_student` VALUES (47, '1621', '徐晓明', 'M', 1, 30, '深圳', 1);
INSERT INTO `tb_student` VALUES (48, '1832', '张震南', 'M', 3, 26, '中山', 2);
INSERT INTO `tb_student` VALUES (49, '1317', '杜晓明', 'M', 2, 22, '中山', 7);
INSERT INTO `tb_student` VALUES (50, '1869', '田詩涵', 'F', 1, 26, '成都市', 1);
INSERT INTO `tb_student` VALUES (51, '1453', '姚杰宏', 'M', 0, 23, '深圳', 4);
INSERT INTO `tb_student` VALUES (52, '1705', '向秀英', 'F', 0, 20, '东莞', 5);
INSERT INTO `tb_student` VALUES (53, '1361', '邹杰宏', 'M', 1, 19, '成都市', 5);
INSERT INTO `tb_student` VALUES (54, '1230', '刘子韬', 'M', 3, 15, '广州市', 2);
INSERT INTO `tb_student` VALUES (55, '1991', '韩睿', 'M', 2, 26, '北京市', 8);
INSERT INTO `tb_student` VALUES (56, '1959', '汤杰宏', 'M', 1, 19, '深圳', 1);
INSERT INTO `tb_student` VALUES (57, '1510', '向震南', 'M', 1, 14, '深圳', 5);
INSERT INTO `tb_student` VALUES (58, '1290', '赵晓明', 'M', 1, 28, '广州市', 6);
INSERT INTO `tb_student` VALUES (59, '1636', '汤詩涵', 'F', 2, 16, '上海市', 9);
INSERT INTO `tb_student` VALUES (60, '1674', '谭致远', 'M', 2, 23, '东莞', 7);
INSERT INTO `tb_student` VALUES (61, '1586', '袁子异', 'M', 0, 28, '中山', 5);
INSERT INTO `tb_student` VALUES (62, '1169', '沈璐', 'F', 2, 26, '成都市', 2);
INSERT INTO `tb_student` VALUES (63, '1795', '曾晓明', 'M', 3, 28, '深圳', 3);
INSERT INTO `tb_student` VALUES (64, '1219', '张子异', 'M', 1, 20, '北京市', 3);
INSERT INTO `tb_student` VALUES (65, '1337', '向岚', 'F', 2, 19, '中山', 10);
INSERT INTO `tb_student` VALUES (66, '1086', '贺詩涵', 'F', 0, 22, '广州市', 10);
INSERT INTO `tb_student` VALUES (67, '1670', '吕詩涵', 'F', 0, 18, '成都市', 3);
INSERT INTO `tb_student` VALUES (68, '1100', '贺睿', 'M', 1, 17, '中山', 6);
INSERT INTO `tb_student` VALUES (69, '1905', '崔子韬', 'M', 1, 16, '广州市', 7);
INSERT INTO `tb_student` VALUES (70, '1152', '孙璐', 'F', 3, 18, '上海市', 6);
INSERT INTO `tb_student` VALUES (71, '1147', '武詩涵', 'F', 1, 21, '上海市', 10);
INSERT INTO `tb_student` VALUES (72, '1535', '蒋晓明', 'M', 3, 20, '上海市', 3);
INSERT INTO `tb_student` VALUES (73, '1962', '胡杰宏', 'M', 2, 16, '中山', 7);
INSERT INTO `tb_student` VALUES (74, '1326', '谢詩涵', 'F', 0, 21, '上海市', 7);
INSERT INTO `tb_student` VALUES (75, '1031', '卢安琪', 'F', 2, 17, '深圳', 10);
INSERT INTO `tb_student` VALUES (76, '1892', '阎秀英', 'F', 2, 24, '东莞', 4);
INSERT INTO `tb_student` VALUES (77, '1518', '任晓明', 'M', 0, 18, '北京市', 8);
INSERT INTO `tb_student` VALUES (78, '1129', '段詩涵', 'F', 2, 16, '中山', 9);
INSERT INTO `tb_student` VALUES (79, '1112', '钟宇宁', 'M', 1, 21, '北京市', 7);
INSERT INTO `tb_student` VALUES (80, '1536', '石子韬', 'M', 2, 29, '成都市', 9);
INSERT INTO `tb_student` VALUES (81, '1635', '段子异', 'M', 2, 25, '北京市', 5);
INSERT INTO `tb_student` VALUES (82, '1665', '毛云熙', 'M', 2, 24, '成都市', 3);
INSERT INTO `tb_student` VALUES (83, '1589', '谢致远', 'M', 2, 17, '深圳', 4);
INSERT INTO `tb_student` VALUES (84, '1852', '黄杰宏', 'M', 1, 27, '成都市', 4);
INSERT INTO `tb_student` VALUES (85, '1185', '田嘉伦', 'M', 3, 16, '成都市', 10);
INSERT INTO `tb_student` VALUES (86, '1710', '朱詩涵', 'F', 2, 28, '东莞', 1);
INSERT INTO `tb_student` VALUES (87, '1026', '魏晓明', 'M', 1, 18, '东莞', 6);
INSERT INTO `tb_student` VALUES (88, '1439', '姜云熙', 'M', 3, 24, '中山', 1);
INSERT INTO `tb_student` VALUES (89, '1549', '常云熙', 'M', 3, 15, '广州市', 4);
INSERT INTO `tb_student` VALUES (90, '1256', '林杰宏', 'M', 1, 24, '成都市', 2);
INSERT INTO `tb_student` VALUES (91, '1329', '毛嘉伦', 'M', 3, 16, '北京市', 5);
INSERT INTO `tb_student` VALUES (92, '1737', '唐宇宁', 'M', 2, 29, '中山', 1);
INSERT INTO `tb_student` VALUES (93, '1217', '邓子韬', 'M', 0, 20, '深圳', 7);
INSERT INTO `tb_student` VALUES (94, '1212', '黎岚', 'F', 1, 17, '广州市', 10);
INSERT INTO `tb_student` VALUES (95, '1909', '李睿', 'M', 1, 23, '上海市', 7);
INSERT INTO `tb_student` VALUES (96, '1349', '袁詩涵', 'F', 2, 21, '深圳', 10);
INSERT INTO `tb_student` VALUES (97, '1271', '林安琪', 'F', 1, 23, '中山', 2);
INSERT INTO `tb_student` VALUES (98, '1274', '罗云熙', 'M', 3, 21, '中山', 7);
INSERT INTO `tb_student` VALUES (99, '1858', '傅子韬', 'M', 2, 17, '上海市', 6);
INSERT INTO `tb_student` VALUES (100, '1819', '卢晓明', 'M', 0, 25, '成都市', 5);

-- ----------------------------
-- Table structure for tb_user
-- ----------------------------
DROP TABLE IF EXISTS `tb_user`;
CREATE TABLE `tb_user`  (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `password` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `nickname` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE,
  UNIQUE INDEX `username_unique`(`username` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of tb_user
-- ----------------------------
INSERT INTO `tb_user` VALUES (1, 'admin', 'admin', '管理员');

SET FOREIGN_KEY_CHECKS = 1;
