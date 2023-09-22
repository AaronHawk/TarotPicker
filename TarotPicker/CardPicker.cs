//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TarotPicker.Models;
//namespace TarotPicker

//    {
        //public class CardPicker

        //{
        //public static readonly Random random = new();
        //private static readonly Dictionary<string, string> cardDescriptions = new()
        //{
        //    // ... populate this
        //};
        //private static readonly Dictionary<string, string> cardImagePaths = new()
        //{
        //    // ... populate this
        //};


        //public static Card[] PickSomeCards(int numberOfCards)
        //{
        //    return Enumerable.Range(0, numberOfCards)
        //                     .Select(_ => GenerateCard())
        //                     .ToArray();
        //}

        //private static Card GenerateCard()
        //{
        //    var card = new Card
        //    {
        //        Name = GetRandomCardName(),
        //        Description = GetCardDescription(card.Name),
        //        ImagePath = GetCardImagePath(card.Name)
        //    };

        //    return card;
        //}
        //private static string GetCardDescription(string cardName)
        //{
        //    return cardDescriptions.TryGetValue(cardName, out var description)
        //        ? description
        //        : "No description available.";
        //}
        //private static string GetCardImagePath(string cardName)
        //{
        //    return cardImagePaths.TryGetValue(cardName, out var imagePath)
        //        ? imagePath
        //        : "Resources/Images/dotnet_bot.png";
        //}
        //public static Card[] PickSomeCards(int numberOfCards)
        //{
        //    Card[] pickedCards = new Card[numberOfCards];
        //    for (int i = 0; i < numberOfCards; i++)
        //    {
        //        Card card = new Card();
        //        card.Name = GetRandomCardName();
        //        card.Description = GetCardDescription(card.Name);
        //        card.ImagePath = GetCardImagePath(card.Name);
        //        pickedCards[i] = card;
        //    }
        //    return pickedCards;
        //}
        //private static string GetRandomCardName()
        //{
        //    string suit = RandomSuit();
        //    string value = RandomValue();

        //    if (suit == "MajorArcana")
        //    {
        //        return RandomMajorArcana();
        //    }
        //    else
        //    {
        //        return $"{value} of {suit}";
        //    }
        //}

        //        private static string GetCardDescription(string cardName)
        //        {
        //            // Create a dictionary to store card descriptions
        //            var cardDescriptions = new Dictionary<string, string>
        //            {

        //                { "0 - The Fool", "The Fool represents new beginnings, spontaneity, and innocence. He is on a journey of self-discovery, unburdened by past experiences. It signifies taking risks and embracing the unknown with an open heart, though it also warns against recklessness and naivety." },
        //                { "1 - The Magician", "The Magician embodies potential, skill, and the power of manifestation. With all 4 elements at his disposal, he can channel divine energy to turn thoughts into reality. The card urges you to tap into your inner resources and take action to achieve your goals." },
        //                { "2 - The High Priestess", "The High Priestess symbolizes intuition, mystery, and the unconscious mind. She encourages you to look within, trust your instincts, and connect with your deeper wisdom. Embrace your inner knowledge and embrace the unseen aspects of life." },
        //                { "3 - The Empress", "The Empress represents fertility, nurturing, and abundance. She is the mother archetype, signifying creativity, love, and the natural world. This card urges you to embrace your nurturing side, find beauty in your surroundings, and appreciate life's abundance." },
        //                { "4 - The Emperor", "The Emperor embodies authority, structure, and leadership. He encourages you to take charge of your life, establish boundaries, and create a stable foundation for future endeavors. This card reminds you to be decisive and assertive when necessary." },
        //                { "5 - The Hierophant", "The Hierophant represents tradition, spirituality, and guidance. As a teacher or mentor, he advocates for conformity to established beliefs and institutions. Seek wisdom from spiritual sources, but remember to balance it with your inner voice." },
        //                { "6 - The Lovers", "The Lovers signify love, partnerships, and choices. This card presents an invitation to explore deep emotional connections and make significant decisions about relationships. It encourages you to follow your heart and embrace authentic love." },
        //                { "7 - The Chariot", "The Chariot symbolizes determination, willpower, and success through hard work. It represents moving forward, overcoming obstacles, and achieving victory. This card advises you to stay focused on your goals and maintain control over opposing forces." },
        //                { "8 - Strength", "Strength embodies courage, inner strength, and compassion. It signifies the triumph of patience and love over anger and aggression. This card urges you to harness your inner power and face challenges with grace and understanding." },
        //                { "9 - The Hermit", "The Hermit represents introspection, solitude, and inner guidance. This card encourages you to seek wisdom through self-reflection and meditation. Embrace al1 time to gain insight and discover your true path." },
        //                { "10 - Wheel of Fortune", "The Wheel of Fortune symbolizes change, destiny, and cycles. Life's ups and downs are depicted on this card, reminding you that nothing is permanent. Embrace change, as it is an opportunity for growth and evolution." },
        //                { "11 - Justice", "Justice embodies fairness, balance, and impartiality. This card urges you to seek truth and act with integrity. Decisions made with clear judgment and fairness will bring about just outcomes." },
        //                { "12 - The Hanged Man", "The Hanged Man signifies surrender, suspension, and seeing things from a different perspective. This card advises you to let go of control and embrace life's flow. Sometimes, inaction leads to profound insights and breakthroughs." },
        //                { "13 - Death", "Death represents transformation, endings, and rebirth. It is not a literal death but rather a symbolic change. Embrace the natural cycles of life and welcome new beginnings that arise from necessary endings." },
        //                { "14 - Temperance", "Temperance embodies balance, harmony, and moderation. This card urges you to find middle ground and avoid extremes. Seek to integrate different aspects of your life for inner peace." },
        //                { "15 - The Devil", "The Devil symbolizes temptation, materialism, and bondage. It warns against negative attachments and unhealthy habits. Face your inner demons and break free from self-imposed limitations." },
        //                { "16 - The Tower", "The Tower signifies sudden upheaval, destruction, and revelation. This card heralds a breakthrough or awakening through the collapse of old structures. Embrace change and see it as an opportunity to rebuild stronger foundations." },
        //                { "17 - The Star", "The Star represents hope, inspiration, and spiritual guidance. This card encourages you to have faith in the future and trust the universe's benevolence. Follow the light of your dreams." },
        //                { "18 - The Moon", "The Moon embodies intuition, subconscious, and mystery. It reminds you that things are not always as they seem, urging you to trust your instincts and navigate through uncertainty." },
        //                { "19 - The Sun", "The Sun signifies joy, success, and vitality. This card represents a time of clarity and positivity. Embrace your authenticity and let your inner light shine." },
        //                { "20 - Judgment", "Judgment symbolizes rebirth, awakening, and self-reflection. It calls for self-assessment and accepting the consequences of your actions. Embrace transformation and start anew." },
        //                { "21 - The World", "The World represents completion, fulfillment, and accomplishment. It signifies the end of a significant life cycle and the beginning of a new phase. Celebrate your achievements and prepare for new adventures." },
        //                { "King of Cups", "The King of Cups embodies emotional maturity, compassion, and wisdom. He represents a calm and balanced individual who is in touch with his emotions and able to offer support and understanding to others." },
        //                { "Queen of Cups", "The Queen of Cups represents empathy, intuition, and nurturing. She is a symbol of emotional stability and maternal instincts. Her presence urges you to trust your feelings and explore the depths of your heart." },
        //                { "Knight of Cups", "The Knight of Cups embodies romance, charm, and artistic inspiration. He brings messages of love and represents a romantic dreamer, encouraging you to follow your heart and pursue creative endeavors." },
        //                { "Page of Cups", "The Page of Cups signifies new emotional experiences, creativity, and youthful exuberance. He brings messages of love and inspiration, encouraging you to explore your emotions and embrace your inner child." },
        //                { "10 of Cups", "The 10 of Cups represents joy, happiness, and harmonious family life. It signifies emotional fulfillment and contentment in your relationships. Enjoy the bonds you share with loved ones." },
        //                { "9 of Cups", "The 9 of Cups embodies wishes fulfilled, contentment, and emotional satisfaction. Known as the 'wish card,' it encourages you to pursue your dreams and find happiness within yourself." },
        //                { "8 of Cups", "The 8 of Cups signifies moving on, seeking deeper meaning, and leaving the past behind. It represents a journey of self-discovery and spiritual growth. Embrace change as an opportunity for personal transformation." },
        //                { "7 of Cups", "The 7 of Cups symbolizes choices, possibilities, and daydreaming. It advises you to be clear about your desires and avoid being overwhelmed by unrealistic expectations. Focus on what truly matters." },
        //                { "6 of Cups", "The 6 of Cups represents nostalgia, kindness, and reconnecting with the past. It encourages you to cherish fond memories and find comfort in familiar places or people from your history." },
        //                { "5 of Cups", "The 5 of Cups signifies grief, loss, and the need to find solace. It urges you to process your emotions and seek healing from past hurts. Look for the positive aspects in challenging situations." },
        //                { "4 of Cups", "The 4 of Cups symbolizes contemplation, introspection, and missed opportunities. It urges you to be open to new possibilities and not become complacent or overly focused on what you lack." },
        //                { "3 of Cups", "The 3 of Cups represents celebration, friendship, and joyful gatherings. It signifies moments of happiness and social connections. Enjoy the camaraderie and shared experiences with others." },
        //                { "2 of Cups", "The 2 of Cups embodies harmony, partnership, and mutual attraction. It signifies the po10tial for a deep emotional connection or a new romantic relationship. Embrace the power of love and connection." },
        //                { "Ace of Cups", "The Ace of Cups represents new emotional beginnings, love, and spiritual connection. It signifies a surge of positive emotions and the po10tial for significant emotional growth." },
        //                { "King of Swords", "The King of Swords symbolizes intellectual power, authority, and truth. He embodies clear thinking and rationality, urging you to make decisions based on logic and objective analysis." },
        //                { "Queen of Swords", "The Queen of Swords embodies intellect, independence, and direct communication. She encourages you to speak your truth with honesty and assertiveness while remaining compassionate and fair." },
        //                { "Knight of Swords", "The Knight of Swords represents action, ambition, and a determined spirit. He embodies the energy of swift movement and encourages you to pursue your goals with focus and determination." },
        //                { "Page of Swords", "The Page of Swords symbolizes curiosity, intellect, and the pursuit of knowledge. He urges you to embrace your inquisitive nature and approach challenges with a fresh and open mind." },
        //                { "10 of Swords", "The 10 of Swords signifies endings, rock bottom, and the possibility of a fresh start. It represents a moment of culmination or crisis, reminding you that the darkest hour is just before dawn." },
        //                { "9 of Swords", "The 9 of Swords embodies anxiety, nightmares, and inner turmoil. It encourages you to confront your fears and seek support during difficult times. Remember that worries are of10 exaggerated." },
        //                { "8 of Swords", "The 8 of Swords represents feeling trapped, self-imposed restrictions, and seeking liberation. It reminds you that the limitations you perceive are of10 of your own making. Free yourself from self-doubt." },
        //                { "7 of Swords", "The 7 of Swords signifies deception, betrayal, and the need to protect oneself. It advises caution in situations where trust may be compromised. Be vigilant and maintain your boundaries." },
        //                { "6 of Swords", "The 6 of Swords embodies transition, moving on, and seeking a calmer future. It signifies a journey away from difficulties and toward a more peaceful and stable phase of life." },
        //                { "5 of Swords", "The 5 of Swords represents conflict, power struggles, and the importance of compromise. It urges you to find common ground and avoid pursuing victory at the expense of others." },
        //                { "4 of Swords", "The 4 of Swords symbolizes rest, contemplation, and self-renewal. It advises taking a break from the busyness of life to recharge and find clarity through peaceful reflection." },
        //                { "3 of Swords", "The 3 of Swords embodies heartache, sorrow, and emotional pain. It signifies a period of grief and emotional release. Allow yourself to process your feelings and heal from heartbreak." },
        //                { "2 of Swords", "The 2 of Swords represents indecision, stalemate, and the need for resolution. It urges you to face difficult choices with h1sty and objectivity to move forward with clarity." },
        //                { "Ace of Swords", "The Ace of Swords represents new ideas, mental clarity, and breakthroughs. It signifies a surge of intellectual power and the po10tial for significant mental or communication achievements." },
        //                { "King of Wands", "The King of Wands embodies natural leadership, vision, and entrepreneurship. He is a charismatic individual with a passion for bringing ideas to life. Embrace your creative potential and lead with confidence." },
        //                { "Queen of Wands", "The Queen of Wands embodies determination, creativity, and a vibrant spirit. She encourages you to be confident and passionate in your pursuits, using your inner fire to fuel your ambitions." },
        //                { "Knight of Wands", "The Knight of Wands represents adventure, ambition, and forward momentum. He embodies the spirit of exploration and urges you to take bold risks to achieve your goals." },
        //                { "Page of Wands", "The Page of Wands symbolizes inspiration, enthusiasm, and new opportunities. He encourages you to embrace new experiences with curiosity and an open mind. Be receptive to creative sparks." },
        //                { "10 of Wands", "The 10 of Wands represents burden, responsibility, and the need to delegate. It urges you to release unnecessary stress and seek support when you feel overwhelmed. Lighten your load." },
        //                { "9 of Wands", "The 9 of Wands embodies resilience, determination, and courage. It signifies standing strong in the face of challenges and refusing to give up on your goals, even when obstacles arise." },
        //                { "8 of Wands", "The 8 of Wands represents swift action, progress, and a burst of energy. It signifies a time of accelerated growth and movement toward your objectives. Embrace the momentum." },
        //                { "7 of Wands", "The 7 of Wands symbolizes courage, determination, and standing your ground. It encourages you to defend your beliefs and protect your boundaries, even in the face of opposition." },
        //                { "6 of Wands", "The 6 of Wands represents victory, recognition, and success. It signifies acknowledgment for your efforts and achievements. Celebrate your accomplishments and bask in well-deserved praise." },
        //                { "5 of Wands", "The 5 of Wands embodies competition, conflict, and the need to find common ground. It advises you to collaborate with others to achieve your goals and avoid unnecessary confrontations." },
        //                { "4 of Wands", "The 4 of Wands represents celebration, harmony, and happy gatherings. It signifies moments of joy and social unity. Embrace the spirit of community and shared happiness." },
        //                { "3 of Wands", "The 3 of Wands symbolizes expansion, progress, and seeing your efforts come to fruition. It represents a time of foresight and planning for future success. Look ahead with confidence." },
        //                { "2 of Wands", "The 2 of Wands embodies planning, making decisions, and taking calculated risks. It signifies a crossroads where you must choose a direction. Make bold choices aligned with your vision." },
        //                { "Ace of Wands", "The Ace of Wands represents new beginnings, creativity, and po10tial. It signifies the birth of a new idea or passion, urging you to seize opportunities and unleash your creative energy." },
        //                { "King of Pentacles", "The King of Pentacles symbolizes financial security, success, and practicality. He embodies a responsible and grounded individual who excels in managing material aspects of life." },
        //                { "Queen of Pentacles", "The Queen of Pentacles embodies nurturing, abundance, and practicality. She encourages you to create a stable and harmonious environment by 10ding to your physical and emotional needs." },
        //                { "Knight of Pentacles", "The Knight of Pentacles represents dedication, reliability, and slow but steady progress. He urges you to approach your goals with patience and thoroughness, ensuring lasting success." },
        //                { "Page of Pentacles", "The Page of Pentacles symbolizes curiosity, ambition, and a thirst for knowledge. He encourages you to explore opportunities for growth and invest in your education or skills." },
        //                { "10 of Pentacles", "The 10 of Pentacles represents wealth, prosperity, and family legacy. It signifies abundance and a strong foundation for future generations. Embrace the blessings of your family and heritage." },
        //                { "9 of Pentacles", "The 9 of Pentacles embodies financial independence, self-reliance, and enjoying the fruits of your labor. It signifies a time of personal fulfillment and material comfort." },
        //                { "8 of Pentacles", "The 8 of Pentacles represents craftsmanship, skill development, and hard work. It signifies a time of diligence and dedication to honing your talents. Mastery leads to rewards." },
        //                { "7 of Pentacles", "The 7 of Pentacles symbolizes patience, long-term vision, and reevaluation. It urges you to take stock of your progress and consider your long-term goals and investments." },
        //                { "6 of Pentacles", "The 6 of Pentacles represents generosity, charity, and giving back. It signifies a time of sharing your resources with others and finding fulfillment in acts of kindness." },
        //                { "5 of Pentacles", "The 5 of Pentacles embodies financial hardship, isolation, and the need for support. It urges you to seek help when facing challenges and remember that help is available." },
        //                { "4 of Pentacles", "The 4 of Pentacles signifies stability, possession, and financial security. It urges you to manage your resources wisely and find a balance between saving and spending." },
        //                { "3 of Pentacles", "The 3 of Pentacles represents collaboration, teamwork, and skilled craftsmanship. It signifies a time of recognition for your expertise and the value of working together." },
        //                { "2 of Pentacles", "The 2 of Pentacles embodies balance, adaptability, and juggling priorities. It signifies the need to manage multiple responsibilities and find harmony in a busy life." },
        //                { "Ace of Pentacles", "The Ace of Pentacles represents new opportunities, prosperity, and material abundance. It signifies the po10tial for financial or career success. Plant the seeds for future growth." }
        //};

        //            if (cardDescriptions.TryGetValue(cardName, out var description))
        //            {
        //                return description;
        //            }

        //            return "No description available.";
        //        }

        //        private static string GetCardImagePath(string cardName)
        //        {
        //            // Create a dictionary to store card image paths
        //            var cardImagePaths = new Dictionary<string, string>
        //            {
        //                { "Ace of Wands", "path/to/ace_of_wands.png" },
        //                { "King of Swords", "path/to/king_of_swords.png" },
        //                // Add other card image paths here
        //            };

        //            if (cardImagePaths.TryGetValue(cardName, out var imagePath))
        //            {
        //                return imagePath;
        //            }

        //            return "Resources/Images/dotnet_bot.png"; // Return a placeholder image path if not found
        //        }
        //        private static string RandomMajorArcana()
        //            {
        //                int majorArcana = random.Next(1, 23);
        //                if (majorArcana == 1) return "0 - The Fool";
        //                if (majorArcana == 2) return "1 - The Magician";
        //                if (majorArcana == 3) return "2 - The High Priestess";
        //                if (majorArcana == 4) return "3 - The Empress";
        //                if (majorArcana == 5) return "4 - The Emperor";
        //                if (majorArcana == 6) return "5 - The Hierophant";
        //                if (majorArcana == 7) return "6 - The Lovers";
        //                if (majorArcana == 8) return "7 - The Chariot";
        //                if (majorArcana == 9) return "8 - Strength";
        //                if (majorArcana == 10) return "9 - The Hermit";
        //                if (majorArcana == 11) return "10 - Wheel of Fortune";
        //                if (majorArcana == 12) return "11 - Justice";
        //                if (majorArcana == 13) return "12 - The Hanged Man";
        //                if (majorArcana == 14) return "13 - Death";
        //                if (majorArcana == 15) return "14 - Temperance";
        //                if (majorArcana == 16) return "15 - The Devil";
        //                if (majorArcana == 17) return "16 - The Tower";
        //                if (majorArcana == 18) return "17 - The Star";
        //                if (majorArcana == 19) return "18 - The Moon";
        //                if (majorArcana == 20) return "19 - The Sun";
        //                if (majorArcana == 21) return "20 - Judgment";
        //                if (majorArcana == 22) return "21 - The World";
        //                return "MISTAKE";

        //            }

        //            private static string RandomSuit()
        //            {
        //                int suitValue = random.Next(1, 6);
        //                if (suitValue == 1) return "Wands";
        //                if (suitValue == 2) return "Cups";
        //                if (suitValue == 3) return "Pentacles";
        //                if (suitValue == 4) return "Swords";
        //                else return "MajorArcana";
        //            }

        //            private static string RandomValue()
        //            {
        //                int valueOfCard = random.Next(1, 15);
        //                if (valueOfCard == 1) return "Ace";
        //                if (valueOfCard == 11) return "Page";
        //                if (valueOfCard == 12) return "Knight";
        //                if (valueOfCard == 13) return "Queen";
        //                if (valueOfCard == 14) return "King";
        //                return valueOfCard.ToString();

        //            }
//    }
//}
