-- MySQL Script generated by MySQL Workbench
-- Fri Nov  1 09:13:43 2019
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Lote`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Lote` (
  `ID_Lote` INT NOT NULL,
  PRIMARY KEY (`ID_Lote`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Produto` (
  `ID_Produto` INT NOT NULL,
  `Prod_name` VARCHAR(50) NOT NULL,
  `Prod_Valor` DOUBLE NOT NULL,
  `Lote_ID_Lote` INT NOT NULL,
  PRIMARY KEY (`ID_Produto`, `Lote_ID_Lote`),
  UNIQUE INDEX `idProduto_UNIQUE` (`ID_Produto` ASC) VISIBLE,
  INDEX `fk_Produto_Lote1_idx` (`Lote_ID_Lote` ASC) VISIBLE,
  CONSTRAINT `fk_Produto_Lote1`
    FOREIGN KEY (`Lote_ID_Lote`)
    REFERENCES `mydb`.`Lote` (`ID_Lote`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Endereco` (
  `ID_Endereco` INT NOT NULL,
  PRIMARY KEY (`ID_Endereco`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Fornecedores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Fornecedores` (
  `ID_CNPJ` VARCHAR(16) NOT NULL,
  `ID_Endereco` INT NOT NULL,
  `Fornecedorescol` VARCHAR(45) NULL,
  PRIMARY KEY (`ID_CNPJ`, `ID_Endereco`),
  INDEX `fk_Fornecedores_Endereco1_idx` (`ID_Endereco` ASC) VISIBLE,
  CONSTRAINT `fk_Fornecedores_Endereco1`
    FOREIGN KEY (`ID_Endereco`)
    REFERENCES `mydb`.`Endereco` (`ID_Endereco`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Consumidores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Consumidores` (
  `ID_CPF` VARCHAR(11) NOT NULL,
  PRIMARY KEY (`ID_CPF`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Forn_Prod`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Forn_Prod` (
  `ID_FornProd` INT NOT NULL,
  `ID_CNPJ` INT NOT NULL,
  PRIMARY KEY (`ID_FornProd`, `ID_CNPJ`),
  INDEX `fk_Produto_has_Fornecedores_Fornecedores1_idx` (`ID_CNPJ` ASC) VISIBLE,
  INDEX `fk_Produto_has_Fornecedores_Produto_idx` (`ID_FornProd` ASC) VISIBLE,
  CONSTRAINT `fk_Produto_has_Fornecedores_Produto`
    FOREIGN KEY (`ID_FornProd`)
    REFERENCES `mydb`.`Produto` (`ID_Produto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Produto_has_Fornecedores_Fornecedores1`
    FOREIGN KEY (`ID_CNPJ`)
    REFERENCES `mydb`.`Fornecedores` (`ID_CNPJ`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Consumo_Prod`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Consumo_Prod` (
  `ID_ConsumoProd` INT NOT NULL,
  `ID_CPF` VARCHAR(11) NOT NULL,
  PRIMARY KEY (`ID_ConsumoProd`, `ID_CPF`),
  INDEX `fk_Produto_has_Consumidores_Consumidores1_idx` (`ID_CPF` ASC) VISIBLE,
  INDEX `fk_Produto_has_Consumidores_Produto1_idx` (`ID_ConsumoProd` ASC) VISIBLE,
  CONSTRAINT `fk_Produto_has_Consumidores_Produto1`
    FOREIGN KEY (`ID_ConsumoProd`)
    REFERENCES `mydb`.`Produto` (`ID_Produto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Produto_has_Consumidores_Consumidores1`
    FOREIGN KEY (`ID_CPF`)
    REFERENCES `mydb`.`Consumidores` (`ID_CPF`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
