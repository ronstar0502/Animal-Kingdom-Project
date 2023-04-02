using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetShopProject.Migrations
{
    /// <inheritdoc />
    public partial class dataStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Fish" },
                    { 2, "Reptile" },
                    { 3, "Mammal" },
                    { 4, "Bird" },
                    { 5, "Amphibian" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "CategoryId", "Description", "ImageName", "Name" },
                values: new object[,]
                {
                    { 1, 3, "The orca or killer whale is a toothed whale belonging to the oceanic dolphin family, of which it is the largest member. It is the only extant species in the genus Orcinus and is recognizable by its black-and-white patterned body", "https://a-z-animals.com/media/killer-whale-1.jpg", "Orca" },
                    { 2, 2, "The Komodo dragon, also known as the Komodo monitor, is a member of the monitor lizard family Varanidae that is endemic to the Indonesian islands of Komodo, Rinca, Flores, and Gili Motang. It is the largest extant species of lizard, growing to a maximum length of 3 metres, and weighing up to 70 kilograms", "https://i.natgeofe.com/k/c02b35d2-bfd7-4ed9-aad4-8e25627cd481/komodo-dragon-head-on_3x2.jpg", "Komodo Dragon" },
                    { 3, 3, "Zebras are African equines with distinctive black-and-white striped coats. There are three living species: the Grévy's zebra, plains zebra, and the mountain zebra. Zebras share the genus Equus with horses and asses, the three groups being the only living members of the family Equidae", "https://cdn.mos.cms.futurecdn.net/HjFE8NKWuCmgfHCcndJ3rK-1200-80.jpg", "Zebra" },
                    { 4, 1, "The great white shark, also known as the white shark, white pointer, or simply great white, is a species of large mackerel shark which can be found in the coastal surface waters of all the major oceans", "http://t2.gstatic.com/licensed-image?q=tbn:ANd9GcTc2QoE1cN6MBfTWmmeTdmFQAUm0pXA_2vgCezyk5bi8kNcVX6AZ4MhC0Pwq3zpHB6RLo4c5dv3p_2f24w", "Great White Shar" },
                    { 5, 4, "Toucans are members of the Neotropical near passerine bird family Ramphastidae. The Ramphastidae are most closely related to the American barbets. They are brightly marked and have large, often colorful bills. The family includes five genera and over forty different species", "https://animals.sandiegozoo.org/sites/default/files/2016-11/animals_hero_toucan.jpg", "Toucan" },
                    { 6, 5, "Poison dart frog is the common name of a group of frogs in the family Dendrobatidae which are native to tropical Central and South America. These species are diurnal and often have brightly colored bodies. This bright coloration is correlated with the toxicity of the species, making them aposematic", "http://t2.gstatic.com/licensed-image?q=tbn:ANd9GcS4dWV3r50QUqmi3ZUAF_PJ49XTpe6LgjLC4R6btUyrB3EGwdUE9iV2sbCzJ2cCKnZJ6X9QliGjiVBI2gE", "Poison Dart Frog" },
                    { 7, 2, "The king cobra is a venomous elapid snake species, endemic to South and Southeast Asia. It is sole member of the genus Ophiophagus. With an average length of 3.18 to 4 m, it is the world's longest venomous snake and possesses a potent neurotoxic venom that can cause the victim's death in 30 minutes", "https://people.com/thmb/QhqeC2pJCGXFiBkBNMLd6WxF4Nk=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():focal(749x0:751x2)/cobra-file-pic--20b4ecc1b95c45abbf7d2ab31306ca24.jpg", "Cobra Snake" },
                    { 8, 3, "The lion is a large cat of the genus Panthera native to Africa and India. It has a muscular, broad-chested body; short, rounded head; round ears; and a hairy tuft at the end of its tail. It is sexually dimorphic; adult male lions are larger than females and have a prominent mane", "https://cdn.britannica.com/29/150929-050-547070A1/lion-Kenya-Masai-Mara-National-Reserve.jpg", "Lion" },
                    { 9, 3, "Kangaroos are four marsupials from the family Macropodidae (macropods, meaning \"large foot\"). In common use the term is used to describe the largest species from this family, the red kangaroo, as well as the antilopine kangaroo, eastern grey kangaroo, and western grey kangaroo", "https://cdn.mos.cms.futurecdn.net/ETb2xLjvc62eb7PPLspSsU.jpg", "Kangaroo" },
                    { 10, 1, "Pterois is a genus of venomous marine fish, commonly known as lionfish, native to the Indo-Pacific. It is characterized by conspicuous warning coloration with red or black bands, and ostentatious fins with venomous spines", "http://t2.gstatic.com/licensed-image?q=tbn:ANd9GcQJaFfIWJivdbQD7iRqyMmDkg0XvXQgubTOLWUl9jokDhLc4CXYvGts6FNV6FPG3BHJhJs60-FOCAEzrcE", "LionFish" },
                    { 11, 4, "Swans are birds of the family Anatidae within the genus Cygnus. The swans' closest relatives include the geese and ducks. Swans are grouped with the closely related geese in the subfamily Anserinae where they form the tribe Cygnini. Sometimes, they are considered a distinct subfamily, Cygninae", "https://upload.wikimedia.org/wikipedia/commons/3/35/Mute_swan_Vrhnika.jpg", "Swan" },
                    { 12, 2, "The American alligator, sometimes referred to colloquially as a gator or common alligator, is a large crocodilian reptile native to the Southeastern United States. It is one of the two extant species in the genus Alligator, and is larger than the only other living alligator species, the Chinese alligator.", "https://upload.wikimedia.org/wikipedia/commons/0/03/American_Alligator.jpg", "American Alligator" },
                    { 13, 5, "The fire salamander is a common species of salamander found in Europe. It is black with yellow spots or stripes to a varying degree; some specimens can be nearly completely black while on others the yellow is dominant", "https://www.oceanario.pt/content/img/salamander_139419137_marek_r._swadzba.jpg", "Fire Salamander" },
                    { 14, 1, "The mahi-mahi or common dolphinfish is a surface-dwelling ray-finned fish found in off-shore temperate, tropical, and subtropical waters worldwide. Also widely called dorado and dolphin, it is one of two members of the family Coryphaenidae, the other being the pompano dolphinfish", "https://storage.googleapis.com/cdn-ioutdoor-com/2018/01/mahi.jpg", "Mahi Mahi" },
                    { 15, 4, "The golden eagle is a bird of prey living in the Northern Hemisphere. It is the most widely distributed species of eagle. Like all eagles, it belongs to the family Accipitridae. They are one of the best-known birds of prey in the Northern Hemisphere", "http://t1.gstatic.com/licensed-image?q=tbn:ANd9GcQ3McgT6kiyXN7vUlzF6tbQ-uT6d968ma3AA7CmnojzRZYQGTgd2Vw9JyaLu08R9Rh0ChDdW0fMnS84dtE", "Golden Eagle" },
                    { 16, 3, "The polar bear is a hypercarnivorous bear whose native range lies largely within the Arctic Circle, encompassing the Arctic Ocean, its surrounding seas and surrounding land masses. It is the largest extant bear species, as well as the largest extant land carnivore", "http://t1.gstatic.com/licensed-image?q=tbn:ANd9GcSZRpCkMraxqmsgJ8wBU3YYuDaNSXoK-stzQENn4X_z1-SoZGlAl1w8xPPwZejpysDADu5dW7KPq3xH5wk", "Polar Bear" },
                    { 17, 3, "The red fox is the largest of the true foxes and one of the most widely distributed members of the order Carnivora, being present across the entire Northern Hemisphere including most of North America, Europe and Asia, plus parts of North Africa", "http://t3.gstatic.com/licensed-image?q=tbn:ANd9GcT-317dY4oiDRBLuIiKbUc0Lge82NCuT3f8O4IXn_9tB61AvUXiX-nEqXq9qcxGHRSdXGNLnYpKju9ZK1c", "Red Fox" },
                    { 18, 2, "Draco is a genus of agamid lizards that are also known as flying lizards, flying dragons or gliding lizards. These lizards are capable of gliding flight via membranes that may be extended to create wings, formed by an enlarged set of ribs. They are arboreal insectivores", "https://i.ytimg.com/vi/QeDir3p8WBs/maxresdefault.jpg", "Draco - Flying Lizard" },
                    { 19, 4, "The barn owl is the most widely distributed species of owl in the world and one of the most widespread of all species of birds, being found almost everywhere except for the polar and desert regions, Asia north of the Himalayas, most of Indonesia, and some Pacific Islands", "https://cdn.download.ams.birds.cornell.edu/api/v1/asset/297342281/1800", "Barn Owl" },
                    { 20, 1, "Swordfish, also known as broadbills in some countries, are large, highly migratory predatory fish characterized by a long, flat, pointed bill. They are a popular sport fish of the billfish category, though elusive. Swordfish are elongated, round-bodied, and lose all teeth and scales by adulthood", "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2023/01/640/320/iStock-1329438563.jpg?ve=1&tl=1", "SwordFish" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "commentId", "AnimalId", "CommentText" },
                values: new object[,]
                {
                    { 1, 1, "My favorite animal is the orca. I love to watch them play, and I love the way they move. They are very playful and they are very intelligent. This product caught my attention when I was looking for something to help capture the movement of the orca in the wild. I was surprised to find that the camera was capable of capturing the movement of an orca even when it was submerged in the water. This is a great product to capture the movement of an animal which is" },
                    { 2, 1, "I've seen these little guys in the water before, but I had no idea they were so big!" },
                    { 3, 1, "I own two Orca and I love them! The first time I saw one, I wanted one. I have seen video footage of other people swimming with them, and I would LOVE to be able to do this. This is a great product. " },
                    { 4, 1, "Orca is a great animal to watch in the wild. They are larger than killer whales and they have a similar diet of fish. They also can be found in the wild right on the coast of the United States.\r\nI got to know Orca when I was out on a whale watching trip. I was watching a pod of orcas swimming in the Pacific Ocean off the coast of California. I was amazed by the beauty and grace of these whales. They swam and played for" },
                    { 5, 1, "I've been a huge fan of Orca since I first saw it on the Discovery Channel. I love watching these guys play and interact with each other, and even once in a while they'll play with me. They're sort of like a big brother and sister who play and are just a pleasure to watch. I have a 100-gallon tank in my backyard and that's where I keep them. I just love them, and they've become my favorite kind of animal" },
                    { 6, 1, "I had the opportunity to see orcas in the wild and it was truly an unforgettable experience. Their grace and intelligence was evident in the way they moved and communicated with each other" },
                    { 7, 2, "I've always been fascinated by Komodo dragons and finally got to see them in person at a zoo. The enclosure was well-designed and provided a good view of the dragons, but I couldn't help feeling sad that they were in captivity" },
                    { 8, 2, "I went on a guided tour to see Komodo dragons on their island and it was a unique and unforgettable experience. The guides were knowledgeable and provided a lot of information about the biology and behavior of the dragons" },
                    { 9, 2, "I had the opportunity to visit a sanctuary that houses Komodo dragons and it was an amazing experience. The size and power of these animals is truly impressive and it was incredible to see them up close in their natural habitat" },
                    { 10, 3, "I had the chance to visit a wildlife reserve and was lucky enough to see a herd of zebras grazing in the open field. The sight of these beautiful animals with their unique stripes was truly breathtaking" },
                    { 11, 3, "I went on a safari in Africa and seeing the zebras in their natural habitat was a highlight of the trip. Their social dynamics and behavior was fascinating to observe" },
                    { 12, 4, "I recently watched a documentary about great white sharks and was struck by how misunderstood these creatures are. It was eye-opening to learn about their behavior and importance in the ocean's ecosystem, and I hope more people come to appreciate and protect them" },
                    { 13, 5, "I had the chance to visit a tropical bird sanctuary and was amazed by the beauty and vibrant colors of the toucans. Their big, colorful beaks and cheerful personalities were a delight to watch and the guides were very knowledgeable about these birds" },
                    { 14, 5, "I went to a zoo and was impressed by the toucan exhibit. The enclosure was large and had plenty of perches and hiding spots, and the birds looked healthy and active. It was great to see these exotic birds up close and learn more about them" },
                    { 15, 6, "I went to a local zoo and was disappointed in the conditions of the poison dart frog exhibit. The enclosure was too small and not well-maintained, and the frogs didn't look healthy. It's important for zoos to provide proper care for these delicate creatures" },
                    { 16, 7, "I had the opportunity to visit a snake sanctuary and was amazed by the beauty and grace of the Cobra snakes. The staff was very knowledgeable and provided a lot of information about the different species and their behaviors" },
                    { 17, 7, "I recently attended a snake handling demonstration and the Cobra snake was by far the most impressive. The handler was able to handle the snake with great care and expertise, and it was an educational experience to learn more about these fascinating creatures" },
                    { 18, 7, "I was disappointed to see Cobra snakes being kept in small, poorly-maintained enclosures at a local zoo. It was clear that the snakes were not being provided with the proper care and space they need. It is important for zoos to provide proper care for all animals, including snakes." },
                    { 19, 8, "I had the chance to go on a safari in Africa and seeing the lions in their natural habitat was a highlight of the trip. Their power and majesty was truly awe-inspiring and it was amazing to see them interact with their pride" },
                    { 20, 8, "I recently visited a zoo and was impressed by the lion exhibit. The enclosure was large and provided a natural environment for the lions to roam, and the staff was knowledgeable and provided a lot of information about the animals." },
                    { 21, 8, "I went to a circus and was deeply saddened by the lion act. The animals looked stressed and it was clear that they were not being treated humanely. I will not support circuses that use wild animals for entertainment" },
                    { 22, 8, "I watched a documentary about lions and was struck by their intelligence and social behavior. It was eye-opening to learn about their importance to the ecosystem and the threats they face in the wild" },
                    { 23, 8, "I read a book about lions and it was an excellent way to learn more about these fascinating animals. The book provides a lot of information about the biology, behavior, and conservation of lions. It was also a great way to experience the lion's life and culture from the comfort of my home" },
                    { 24, 9, "I had the chance to visit a wildlife sanctuary in Australia and seeing the kangaroos in their natural habitat was a highlight of the trip. Their unique hopping gait and ability to carry their young in a pouch was truly fascinating to observe" },
                    { 25, 9, "I recently visited a zoo and was impressed by the kangaroo exhibit. The enclosure was large and provided a natural environment for the kangaroos to roam, and the staff was knowledgeable and provided a lot of information about the animals" },
                    { 26, 10, "I had the opportunity to go diving in a coral reef and was amazed by the beauty and vibrant colors of the lionfish. Their unique appearance and behavior made for an interesting and educational experience" },
                    { 27, 11, "I had the chance to visit a lake and was amazed by the grace and beauty of the swans. Their elegant movements and the way they glide on the water was truly mesmerizing to watch" },
                    { 28, 11, "I recently went to a park and saw a pair of swans building a nest. It was fascinating to watch the process and see how dedicated the pair were to each other and their offspring" },
                    { 29, 11, "I was disappointed to see swans being treated poorly at a local pond. People were feeding them bread and not respecting their space, and it was clear that the swans were not being treated with the respect they deserve. It is important to remember that these are wild animals and should be treated with care and respect" },
                    { 30, 12, "I recently went on a swamp tour and saw American alligators in their natural habitat. It was a truly unforgettable experience to see these powerful creatures in the wild and learn about their role in the ecosystem" },
                    { 31, 12, "I was disappointed to see American alligators being kept in small, poorly-maintained enclosures at a local zoo. It was clear that the alligators were not being provided with the proper care and space they need. It is important for zoos to provide proper care for all animals, including alligators" },
                    { 32, 13, "I had the opportunity to visit a nature reserve and was amazed by the vibrant colors of the fire salamanders. Their unique pattern and coloration made them easy to spot amongst the forest floor and the staff was knowledgeable and provided a lot of information about the animals and their habitat" },
                    { 33, 14, "I recently caught a mahi mahi while deep sea fishing and it was an exciting and tasty experience. The fish was cooked on the boat and was some of the freshest and most flavorful fish I have ever had" },
                    { 34, 14, "I recently went on a fishing trip and caught a Mahi Mahi. It was a great fight and the taste of the fresh fish was incredible. I couldn't wait to cook it for my family and friends" },
                    { 35, 15, "I had the opportunity to visit a wildlife sanctuary and was amazed by the beauty and power of the golden eagle. The staff was knowledgeable and provided a lot of information about the animals, their habitat, and conservation efforts" },
                    { 36, 15, "I recently went on a hike and was lucky enough to spot a golden eagle in the wild. It was an incredible experience to see such a majestic bird in its natural habitat" },
                    { 37, 16, "I had the opportunity to visit a zoo and was amazed by the size and power of the polar bears. The staff was knowledgeable and provided a lot of information about the animals, their habitat, and conservation efforts" },
                    { 38, 16, "I recently went on a wildlife safari and was lucky enough to spot a polar bear in the wild. It was an incredible experience to see such a majestic animal in its natural habitat" },
                    { 39, 16, "I was disappointed to see polar bears being kept in small, poorly-maintained enclosures at a zoo. It was clear that the bears were not being provided with the proper care and space they need. It is important for zoos to provide proper care for all animals, including polar bears" },
                    { 40, 16, "I had the opportunity to visit a polar bear exhibit at a natural history museum and was impressed by the level of detail and information provided. It was fascinating to learn about their biology, behavior, and conservation status. The exhibit was well-done and interactive which made it enjoyable for visitors of all ages" },
                    { 41, 17, "I had the opportunity to visit a wildlife sanctuary and was impressed by the beauty and intelligence of the red fox. The staff was knowledgeable and provided a lot of information about the animals, their habitat, and conservation efforts" },
                    { 42, 17, "I recently went on a hike and was lucky enough to spot a red fox in the wild. It was an incredible experience to see such a graceful animal in its natural habitat" },
                    { 43, 17, "I had the opportunity to visit a red fox exhibit at a natural history museum and was impressed by the level of detail and information provided. It was fascinating to learn about their biology, behavior, and conservation status. The exhibit was well-done and interactive which made it enjoyable for visitors of all ages" },
                    { 44, 17, "I had the chance to watch a documentary about red foxes, it was very informative and gave me a deep understanding about their behavior, diet and habitat. It was also very interesting to learn about the different subspecies of red fox and their geographic distribution" },
                    { 45, 18, "I recently went on a hike in a tropical rainforest and was lucky enough to spot a Draco flying lizard in the wild. It was an incredible experience to see such a unique animal in its natural habitat" },
                    { 46, 18, "I was disappointed to see Draco flying lizards being kept in small, poorly-maintained enclosures at a zoo. It was clear that the lizards were not being provided with the proper care and space they need. It is important for zoos to provide proper care for all animals, including Draco flying lizards" },
                    { 47, 19, "I recently went on a hike and was lucky enough to spot a barn owl in the wild. It was an incredible experience to see such a majestic animal in its natural habitat" },
                    { 48, 19, "I had the opportunity to visit a bird sanctuary and was impressed by the beauty and grace of the barn owl. The staff was knowledgeable and provided a lot of information about the animals, their habitat, and conservation efforts" },
                    { 49, 20, "I went on a deep sea fishing trip and caught a swordfish. It was an exhilarating experience and the fish was delicious when we cooked it later that night" },
                    { 50, 20, "I watched a documentary about swordfish and was fascinated by their strength and agility. It was also eye-opening to learn about the fishing industry and the impact on swordfish populations" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "commentId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "categoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "categoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "categoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "categoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "categoryId",
                keyValue: 5);
        }
    }
}
