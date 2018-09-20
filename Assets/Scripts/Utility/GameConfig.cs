using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public static class GameConfig 
{
	public static int score = 0;
	public static int currentStage = 1;
	public static int sceneTracker = 3;
	public static string stageName = "Stage Tokyo";
	public static string[,] stages_tokyo = new string[11, 5] {
		{"head", "head", "head", "head", "head"},
		{"Tokyo Skytree", "Tokyo Tower", "Shanghai Tower", "Eiffel Tower", "Tokyo Skytree"},
		{"Meiji Shrine", "Shinto shrine", "Meiji Shrine", "Kumano Shrine", "Tenmagu Shrine"}, 
		{"Senso-ji", "Kanei-ji", "Senso-ji", "Zenyōmitsu-ji", "Gokoku-ji"},
		{"Odaiba", "Shinjuku", "Ginza", "Harajuku", "Odaiba"},
		{"Roppongi", "Ikebukuro", "Shinagawa", "Roppongi", "Yoyogi"},
		{"Tokyo Dome", "Tokyo Dome", "Saitama Stadium", "Ryōgoku Kokugikan", "Ajinomoto Stadium"},
		{"Tokyo Station", "Shinjuku Station", "Tokyo Station", "Ueno Station", "Akihabara Station"},
		{"Tokyo Tower", "Tokyo Tower", "Tokyo Skytree", "JP Tower", "Roppongi Mori Tower"},
		{"Ueno Station", "Kanda Station", "Yotsuya Station", "Nippori Station", "Ueno Station"},
		{"Yokohama", "Hokkaido", "Izu", "Osaka", "Yokohama"},
	};
	public static string[,] stages_world = new string[11, 5] {
		{"head", "head", "head", "head", "head"},
		{"Brazil", "Spain", "England", "Germany", "Brazil"},
		{"Dubai", "Dubai", "Shanghai", "Tokyo", "Chicago"},
		{"San Francisco", "New York", "San Francisco", "London", "Paris"},
		{"Italy", "Finland", "Italy", "Greece", "Poland"},
		{"Italy", "France", "Germany", "Romania", "Italy"},
		{"London", "Hongkong", "Madrid", "Rome", "London"},
		{"Houston", "Houston", "San Antonio", "Boston", "Washington DC"},
		{"New York", "Paris", "Beijing", "New York", "Sydney"},
		{"San Francisco", "Livepool", "Kyoto", "Moscow", "San Francisco"},
		{"Kyoto", "Osaka", "Kobe", "Saitama", "Kyoto"},
	};
	public static string[,] stages_nature = new string[11, 5] {
		{"head", "head", "head", "head", "head"},
		{"Hakone", "Fujisan", "Hakone", "Hokkaido", "Izu"},
		{"Grand Canyon", "Yellowstone", "Grand Canyon", "Crater Lake", "Death Valley"},
		{"Grand Canyon", "Grand Teton", "Great Basin", "Haleakalā", "Grand Canyon"},
		{"Antelope Canyon", "Guadalupe Mountains", "Antelope Canyon", "Hawaii Volcanoes", "Hot Springs"},
		{"Moraine Lake", "Tahoe Lake", "Moraine Lake", "Great Salt Lake", "Michigan Lake"},
		{"North Pole", "South Pole", "Greenland", "North Pole", "Iceland"},
		{"The Wave", "The Wave", "The Bowl", "Arches", "Big Bend"},
		{"Ocean Road", "Ocean Bridge", "Ocean Path", "Ocean Road", "Ocean Way"},
		{"Great Wall", "Great Castle", "Great Mountain", "Great Fence", "Great Wall"},
		{"Austrilia", "Thailand", "Hawaii", "Austrilia", "Fiji"},
	};


}
	