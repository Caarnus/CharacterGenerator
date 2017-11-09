drop table if exists character_model;
drop table if exists class_level_model;
drop table if exists race_model;
drop table if exists subrace_model;
drop table if exists vision_model;
drop table if exists background_model;
drop table if exists item_model;
drop table if exists class_model;
drop table if exists archetype_model;
drop table if exists feature_model;
drop table if exists feat_model;
drop table if exists spell_slot_model;
drop table if exists tool_model;
drop table if exists spell_model;
drop table if exists skill_model;
drop table if exists saving_throw_model;
drop table if exists resistance_model;
drop table if exists proficiency_bonus_model;
drop table if exists language_model;
drop table if exists ability_score_improvement_model;
drop table if exists equipment_mode;
drop table if exists attribute_model;
drop table if exists weapon_model;
drop table if exists attack_model;
drop table if exists dice_model;
drop table if exists armor_model;
drop table if exists alignment_model;
drop table if exists damage_model;
drop table if exists damage_type_model;

create table if not exists damage_type_model (
    dty_type varchar(15) primary key
);

create table if not exists damage_model (
	dmg_id int auto_increment primary key
    ,dmg_type varchar(15)
    ,dmg_magic bool
    ,constraint foreign key (dmg_type) references damage_type_model(dty_type) on update cascade
);

create table if not exists alignment_model (
	alg_shortName char(2) primary key
    ,alg_longName varchar(20)
    ,alg_description text
);

create table if not exists armor_model (
	arm_id int auto_increment primary key
    ,arm_type varchar(20)
    ,arm_class varchar(10)
    ,arm_cost int
    ,arm_armorClass int
    ,arm_addDex bool
    ,arm_strReq int
    ,arm_stealthImpair bool
    ,arm_weight decimal
    ,arm_price int
    ,arm_donTime int
    ,arm_doffTime int
    ,arm_proficient bool
);

create table if not exists dice_model (
	dic_id int auto_increment primary key
    ,dic_side int not null default 4
    ,dic_numberRolled int not null default 1
);

create table if not exists attack_model (
	att_id int auto_increment primary key
    ,att_name varchar(30)
    ,att_source varchar(30)
    ,att_diceRoll int
    ,att_damage int
    ,constraint foreign key (att_diceRoll) references dice_model(dic_id) on update cascade
    ,constraint foreign key (att_damage) references damage_model(dmg_id) on update cascade
);

create table if not exists weapon_model (
	wpm_id int auto_increment primary key
    ,wpn_type varchar(20)
    ,wpn_class varchar(10)
    ,wpn_ranged bool
    ,wpn_ammo bool
    ,wpn_finesse bool
    ,wpn_heavy bool
    ,wpn_light bool
    ,wpn_loading bool
    ,wpn_rangeFirst int
    ,wpn_rangeSecond int
    ,wpn_reach bool
    ,wpn_special bool
    ,wpn_thrown bool
    ,wpn_twohand bool
    ,wpn_versatile bool
    ,wpn_damage int
    ,wpn_versatileDamage int
    ,wpn_price int
    ,wpn_weight decimal
    ,wpn_silvered bool
    ,wpn_proficient bool
    ,constraint foreign key (wpn_damage) references attack_model(att_id) on update cascade
    ,constraint foreign key (wpn_versatileDamage) references attack_model(att_id) on update cascade
);

create table if not exists attribute_model (
	atr_shortName char(3) primary key
    ,atr_longName varchar(15)
    ,atr_advantage bool
    ,atr_special varchar(255)
);

create table if not exists equipment_mode (
	eqp_id int auto_increment primary key
    ,eqp_name varchar(40)
    ,eqp_cost int
    ,eqp_weightPerUnit decimal
    ,eqp_unitQuantity decimal
    ,eqp_unit varchar(10)
    ,eqp_description varchar(255)
    ,eqp_bonus int
    ,eqp_type varchar(20)
    ,eqp_subtype varchar(20)
);

create table if not exists ability_score_improvement_model (
	asi_class varchar(20) primary key
    ,asi_level01 int default 0
    ,asi_level02 int default 0
    ,asi_level03 int default 0
    ,asi_level04 int default 0
    ,asi_level05 int default 0
    ,asi_level06 int default 0
    ,asi_level07 int default 0
    ,asi_level08 int default 0
    ,asi_level09 int default 0
    ,asi_level10 int default 0
    ,asi_level11 int default 0
    ,asi_level12 int default 0
    ,asi_level13 int default 0
    ,asi_level14 int default 0
    ,asi_level15 int default 0
    ,asi_level16 int default 0
    ,asi_level17 int default 0
    ,asi_level18 int default 0
    ,asi_level19 int default 0
    ,asi_level20 int default 0
);

create table if not exists language_model (
	lng_id int auto_increment primary key
    ,lng_name varchar(20)
    ,lng_typicalSpeakerList varchar(200)
    ,lng_script varchar(20)
);

create table if not exists proficiency_bonus_model (
	pbn_id int auto_increment primary key
    ,pbn_totalLevel int
    ,pbn_bonusAmount int not null
);

create table if not exists resistance_model (
	res_id int auto_increment primary key
    ,res_damageType varchar(15) not null
    ,res_condition varchar(200)
    ,res_resistAmount decimal
    ,constraint foreign key (res_damageType) references damage_type_model(dty_type) on update cascade
);

create table if not exists saving_throw_model (
	sav_id int auto_increment primary key
    ,sav_name varchar(40)
    ,sav_attributeName char(3) not null
    ,sav_advantage bool
    ,sav_special varchar(200)
    ,sav_proficient bool
    ,constraint foreign key (sav_attributeName) references attribute_model(atr_shortName) on update cascade
);

create table if not exists skill_model (
	skl_id int auto_increment primary key
    ,skl_name varchar(30)
    ,skl_governingAttrib char(3) not null
    ,skl_advantage bool
    ,skl_special varchar(200)
    ,skl_proficient bool
    ,constraint foreign key (skl_governingAttrib) references attribute_model(atr_shortName) on update cascade
);

create table if not exists spell_model (
	spl_id int auto_increment primary key
    ,spl_name varchar(40)
    ,spl_level int not null default 0
    ,spl_castTime int
    ,spl_duration int
    ,spl_range int
    ,spl_verbal bool
    ,spl_somatic bool
    ,spl_material bool
    ,spl_materialDesc varchar(100)
    ,spl_materialConsumed bool
    ,spl_concentration bool
    ,spl_ritual bool
    ,spl_attack bool
    ,spl_reaction bool
    ,spl_description bool
    ,spl_levelReq int
    ,spl_prepared bool
);

create table if not exists tool_model (
	tol_id int auto_increment primary key
    ,tol_name varchar(30)
    ,tol_class varchar(20) not null
    ,tol_cost int
    ,tol_weight decimal
    ,tol_advantage bool
    ,tol_special varchar(200)
    ,tol_proficient bool
);

create table if not exists spell_slot_model (
	slt_id int auto_increment primary key
    ,slt_class varchar(20) not null
    ,slt_classLevel int not null default 1
    ,slt_spellsKnown int
    ,slt_level0Slots int
    ,slt_level1Slots int
    ,slt_level2Slots int
    ,slt_level3Slots int
    ,slt_level4Slots int
    ,slt_level5Slots int
    ,slt_level6Slots int
    ,slt_level7Slots int
    ,slt_level8Slots int
    ,slt_level9Slots int
);

create table if not exists feat_model (
	fet_id int auto_increment primary key
    ,fet_name varchar(20)
    ,fet_prerequisite varchar(40)
    ,fet_effect varchar(200)
);

create table if not exists feature_model (
	ftr_id int auto_increment primary key
    ,ftr_name varchar(20)
    ,ftr_tiedTo varchar(30) not null
    ,ftr_level int not null default 0
    ,ftr_description varchar(200)
    ,ftr_languageList varchar(300)
    ,ftr_weaponList varchar(300)
    ,ftr_armorList varchar(300)
    ,ftr_spellList varchar(300)
    ,ftr_skillList varchar(300)
    ,ftr_featList varchar(300)
    ,ftr_resistanceList varchar(300)    
);

create table if not exists archetype_model (
	arc_id int auto_increment primary key
    ,arc_name varchar(20) not null
    ,arc_class varchar(20) not null
    ,arc_featureList varchar(300)
);

create table if not exists class_model (
	cls_id int auto_increment primary key
    ,cls_name varchar(20)
    ,cls_hitdice int
    ,cls_startingHealth int
    ,cls_defaultHPPerLevel int
    ,cls_DiceHPPerLevel int
    ,cls_armorList varchar(300)
    ,cls_weaponList varchar(300)
    ,cls_toolList varchar(300)
    ,cls_savingThrowList varchar(300)
    ,cls_skillList varchar(300)
    ,cls_equipmentList varchar(300)
    ,cls_featureList varchar(300)
    ,cls_archetypeLevel int
    ,cls_archetypeList varchar(300)
    ,cls_proficiencyList varchar(300)
    ,cls_spellSlotList varchar(300)
    ,cls_spellList varchar(300)
    ,cls_numberAvailableArmorProficiencies int
    ,cls_numberAvailableWeaponProficiencies int
    ,cls_numberAvailableToolProficiencies int
    ,cls_numberAvailableSkillProficiencies int
    ,cls_availableArmorList varchar(300)
    ,cls_availableWeaponList varchar(300)
    ,cls_availableToolList varchar(300)
    ,cls_availableSkillList varchar(300)
    ,cls_abilityScoreImprovement varchar(20)
    ,constraint foreign key (cls_hitdice) references dice_model(dic_id) on update cascade
    ,constraint foreign key (cls_DiceHPPerLevel) references dice_model(dic_id) on update cascade
    ,constraint foreign key (cls_abilityScoreImprovement) references ability_score_improvement_model(asi_class) on update cascade
);

create table if not exists item_model (
	itm_id int auto_increment primary key
    ,itm_name varchar(40)
    ,itm_valueInCopper int
    ,itm_weight decimal
    ,itm_description varchar(100)
);

create table if not exists background_model (
	bkg_id int auto_increment primary key
    ,bkg_name varchar(20)
    ,bkg_skillProficiencyList varchar(300)
    ,bkg_toolProficiencyNumber int
    ,bkg_toolProficiencyList varchar(300)
    ,bkg_languageNumber int
    ,bkg_itemList varchar(300)
    ,bkg_featureList varchar(300)
    ,bkg_description varchar(500)
);

create table if not exists vision_model (
	vis_id int auto_increment primary key
    ,vis_name varchar(20) not null
    ,vis_darkAsDim int
    ,vis_dimAsBright int
    ,vis_blind int
    ,vis_illusionAffected bool
    ,vis_seeMagicDark bool
);

create table if not exists subrace_model (
	sbr_id int auto_increment primary key
    ,sbr_name varchar(20) not null
    ,sbr_strPlus int default 0
    ,sbr_dexPlus int default 0
    ,sbr_conPlus int default 0
    ,sbr_intPlus int default 0
    ,sbr_wisPlus int default 0
    ,sbr_chaPlus int default 0
    ,sbr_visionType int
    ,sbr_descPhysical varchar(500)
    ,sbr_descAlign varchar(500)
    ,sbr_descAttitude varchar(500)
    ,sbr_languageListList varchar(300)
    ,sbr_skillProficiencyListList varchar(300)
    ,sbr_weaponProficiencyListList varchar(300)
    ,sbr_armorProficiencyListList varchar(300)
    ,sbr_toolProficiencyListList varchar(300)
    ,sbr_resistanceListList varchar(300)
    ,sbr_spellListList varchar(300)
    ,sbr_featListList varchar(300)
    ,sbr_bonusAttribute int
    ,sbr_bonusFeat int
    ,sbr_bonusSkill int
    ,sbr_bonusLanguage int
    ,sbr_bonusSpell int
    ,sbr_bonusWeapon int
    ,sbr_bonusArmor int
    ,sbr_bonusAttributeList varchar(300)
    ,sbr_bonusFeatList varchar(300)
    ,sbr_bonusSkillList varchar(300)
    ,sbr_bonusLanguageList varchar(300)
    ,sbr_bonusSpellList varchar(300)
    ,sbr_bonusWeaponList varchar(300)
    ,sbr_bonusArmorList varchar(300)
);

create table if not exists race_model (
	rac_id int auto_increment primary key
    ,rac_name varchar(20) not null
    ,rac_strPlus int default 0
    ,rac_dexPlus int default 0
    ,rac_conPlus int default 0
    ,rac_intPlus int default 0
    ,rac_wisPlus int default 0
    ,rac_chaPlus int default 0
    ,rac_lifeExpectancy int
    ,rac_size char(1)
    ,rac_speed int
    ,rac_visionType int
    ,rac_descPhysical varchar(500)
    ,rac_descAlign varchar(500)
    ,rac_descAttitude varchar(500)
    ,rac_subraceListList varchar(300)
    ,rac_languageListList varchar(300)
    ,rac_skillProficiencyListList varchar(300)
    ,rac_weaponProficiencyListList varchar(300)
    ,rac_armorProficiencyListList varchar(300)
    ,rac_toolProficiencyListList varchar(300)
    ,rac_resistanceListList varchar(300)
    ,rac_spellListList varchar(300)
    ,rac_featListList varchar(300)
    ,rac_bonusAttribute int
    ,rac_bonusFeat int
    ,rac_bonusSkill int
    ,rac_bonusLanguage int
    ,rac_bonusSpell int
    ,rac_bonusWeapon int
    ,rac_bonusArmor int
    ,rac_bonusAttributeList varchar(300)
    ,rac_bonusFeatList varchar(300)
    ,rac_bonusSkillList varchar(300)
    ,rac_bonusLanguageList varchar(300)
    ,rac_bonusSpellList varchar(300)
    ,rac_bonusWeaponList varchar(300)
    ,rac_bonusArmorList varchar(300)
);

create table if not exists class_level_model (
	csl_id int auto_increment primary key
    ,csl_class int not null
    ,csl_level int not null default 1
    ,constraint foreign key (csl_class) references class_model(cls_id) on update cascade
);

create table if not exists character_model (
	cha_id int auto_increment primary key
    ,cha_name varchar(30)
    ,cha_age int
    ,cha_height int
    ,cha_weight int
    ,cha_eyes varchar(20)
    ,cha_skin varchar(20)
    ,cha_hair varchar(20)
    ,cha_alignment char(2)
    ,cha_classLevelList varchar(300)
    ,cha_race int
    ,cha_background int
    ,cha_playerName varchar(40)
    ,cha_experience int
    ,cha_baseStr int
    ,cha_baseDex int
    ,cha_baseCon int
    ,cha_baseInt int
    ,cha_baseWis int
    ,cha_baseCha int
    ,cha_inspiration bool
    ,cha_proficiencyBonus int
    ,cha_savingThrowList varchar(300)
    ,cha_skillList varchar(300)
    ,cha_passivePerception int
    ,cha_weaponList varchar(300)
    ,cha_armorList varchar(300)
    ,cha_toolList varchar(300)
    ,cha_languageList varchar(300)
    ,cha_armorClass int
    ,cha_initiativeBonus int
    ,cha_speed int
    ,cha_currentHP int
    ,cha_tempHP int
    ,cha_maxHP int
    ,cha_maxHitDice int
    ,cha_currentHitDice int
    ,cha_deathSaveSuccess int
    ,cha_deathSaveFail int
    ,cha_attackList varchar(300)
    ,cha_copperAmount int
    ,cha_silverAmount int
    ,cha_electrumAmount int
    ,cha_goldAmount int
    ,cha_platinumAmount int
    ,cha_equipmentList varchar(300)
    ,cha_personalityTraits varchar(200)
    ,cha_ideals varchar(200)
    ,cha_bonds varchar(200)
    ,cha_flaws varchar(200)
    ,cha_featureList varchar(300)
    ,cha_appearanceImageFilePath varchar(50)
    ,cha_characterBackstory varchar(2000)
    ,cha_alliesAndOrgFilePath varchar(50)
    ,cha_alliesAndOrganizations varchar(500)
    ,cha_additionalFeatureList varchar(300)
    ,cha_itemList varchar(300)
    ,cha_spellCastingClass int
    ,cha_spellCastingAbility char(3)
    ,cha_spellSaveDC int
    ,cha_spellAttackBonus int
    ,cha_spellSlotMax1 int
    ,cha_spellSlotRemaining1 int
    ,cha_spellSlotMax2 int
    ,cha_spellSlotRemaining2 int
    ,cha_spellSlotMax3 int
    ,cha_spellSlotRemaining3 int
    ,cha_spellSlotMax4 int
    ,cha_spellSlotRemaining4 int
    ,cha_spellSlotMax5 int
    ,cha_spellSlotRemaining5 int
    ,cha_spellSlotMax6 int
    ,cha_spellSlotRemaining6 int
    ,cha_spellSlotMax7 int
    ,cha_spellSlotRemaining7 int
    ,cha_spellSlotMax8 int
    ,cha_spellSlotRemaining8 int
    ,cha_spellSlotMax9 int
    ,cha_spellSlotRemaining9 int
    ,cha_spellList varchar(300)
);