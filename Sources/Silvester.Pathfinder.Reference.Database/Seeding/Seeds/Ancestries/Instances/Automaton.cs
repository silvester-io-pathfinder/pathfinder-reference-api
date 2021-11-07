using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;


namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances
{
    public class Automaton : Template
    {
        public static readonly Guid ID = Guid.Parse("6bfd23ad-1fd2-4641-997f-a9d3db5fa92a");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Automaton", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Rare.ID, 
                SampleNames = "Alnhaman, Busmin, The Doleful, Enoh, Himar, Kantral, The Kindred, Numinar, Scholar, Tehkis, Wayfarer, Yulmian"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
            yield return AncestrySizes.Instances.Small.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("fe36d89a-bae8-4dde-8499-0834eb76291f"), Type = TextBlockType.Text, Text = "These intelligent constructs house actual souls and represent what remains of a dying empire's last attempt at greatness. Automatons combine technological ingenuity with magical power, creating a blended being wholly unique to Golarion." };
            yield return new TextBlock { Id = Guid.Parse("ec405862-1eb4-4c63-9cad-feb4e803d49d"), Type = TextBlockType.Text, Text = "The Jistka Imperium was the first majorhumancivilization to emerge after Earthfall, arising around the area that would later become Rahadoum and enduring for seven centuries thanks to great advancements in civics and the sciences. However, Jistka's leaders often favored aggressive uses of technology, and early advances paved the way for arrogance, petty infighting, and corruption. The Jistka Imperium's expansionist tendencies and lack of diplomacy earned the Imperium many enemies over the course of its existence. The most notable of these foes was the empire of Ancient Osirion. Osirion's enmity ultimately sealed the Imperium's fate, as they employed clever and depraved magic that proved more than a match for Jistka's legendary golem army, even when the Jistkans began to cut corners and bind fiends into their golems. In a desperate attempt to fight back against internal corruption and external pressures, a cabal of concerned Jistkans formed the Artificer Conclave to develop new technologies to stave off the Imperium's collapse and return Jistka to its former glory. The most successful of these developments were automatons, which the Conclave believed to be the pinnacle of Jistkan constructs—or at least, the last hope for Jistka's salvation. Conclave creators transplanted the mind, life force, and soul of Jistkan individuals into these constructs, creating magical and technological marvels powered by the life energy of the greatest warriors and scholars the organization could recruit. Unfortunately, despite the Conclave's best efforts, the automatons' arrival happened too late to save the already doomed Imperium. The empire collapsed, leaving automatons to fend for themselves." };
            yield return new TextBlock { Id = Guid.Parse("cf52d2d0-ae97-4e95-98af-48e56bc3fc88"), Type = TextBlockType.Text, Text = "The exceptional and forward-thinking construction of automatons means that a fair number remain today, millennia later, scattered to the winds. However, the passage of time has revealed one of automatons' greatest weaknesses: their mortal psyches. Only the strongest willed have managed to retain their memories, sense of self, and lucidity after all this time. As each automaton remains as unique as any living person on Golarion; a given automaton has their own personality, shaped by countless experiences. Most automatons behave reclusively, preferring to avoid others due to fear of attachment or misunderstanding. Even automatons who are more willing to live in the open understand that their unique nature makes them a prime target for hunters, scholars, or worse. Rare is the automaton that lives without the regular occurrence of distrust or worry." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you want to play a character who is a living construct with powerful potential and ties to ancient magic, you should play an automaton." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("4f93f101-73ac-4ee4-9317-c38c6aacc568"), Type = TextBlockType.Enumeration, Text = "Have lived for several centuries and through many significant events." };
            yield return new TextBlock { Id = Guid.Parse("16675e97-461a-4d02-a812-77d6ed2eb5cd"), Type = TextBlockType.Enumeration, Text = "Be hesitant to trust others until they've earned it." };
            yield return new TextBlock { Id = Guid.Parse("17f3043c-dd72-432b-a497-4f83fca7d3b0"), Type = TextBlockType.Enumeration, Text = "Remember little of your life before becoming an automaton." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("a9834738-b8cc-4bf9-826c-4cbb64d3a83b"), Type = TextBlockType.Enumeration, Text = "Mistake you for a mindless construct when they first see you." };
            yield return new TextBlock { Id = Guid.Parse("54e8bc4b-1ddd-4c52-ac58-080d195c4c40"), Type = TextBlockType.Enumeration, Text = "Assume you have secret knowledge about magic and technology." };
            yield return new TextBlock { Id = Guid.Parse("21c77fe1-5073-4369-909c-70e0f7c585bf"), Type = TextBlockType.Enumeration, Text = "Look upon you with awe." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("a57107b4-9da2-435f-b179-4de1d6f60ab8"), Type = TextBlockType.Text, Text = "Automatons share a common construction—a blend of magically treated metals and stone. This design allows automatons to withstand the rigors of direct combat and makes them particularly hardy. Their heavy bodies can move just as quickly as other combatants, making automatons intimidating foes. The design of an automaton varies depending on the needs of its role. Most automatons have a basic humanoid shape, though some instead have shapes that closely resemble animals. The majority of automatons have a single eye that glows with a dim, magical light. Each also contains a powerful artifact that both houses its individual soul and uses a combination of life and planar energy for power. Theseautomaton coresare marvels of magical engineering whose method of creation has been lost to time." };
            yield return new TextBlock { Id = Guid.Parse("a132daa9-cb19-4540-a779-401fe4349152"), Type = TextBlockType.Text, Text = "As constructs, automatons typically don't need to breathe, eat, or sleep; however, the body of an automaton needs to vent an imperceivable magical exhaust at a constant rate. This venting process requires breathable air to prevent a buildup of exhaust that can clog the automaton's systems, sometimes to fatal effect. Thus, automatons can still suffocate much like living creatures. Though they don't sleep, automatons require a period of magical recalibration and restoration which stabilizes the energies within their core. Without this process, anautomaton coreis incapable of fully powering the automaton and they enter an inefficient state (similar to a humanoid who doesn't get 8 hours of sleep)." };
            yield return new TextBlock { Id = Guid.Parse("c589acba-51d3-474f-9151-012d1768d052"), Type = TextBlockType.Text, Text = "Automatons don't age and the design of their cores grants them a seemingly endless power source. Many automatons that exist today are thousands of years old, their bodies as efficient as the day of their creation, even if their minds might have deteriorated with the strain of the ages. Automatons lost over time typically met violent ends. An automaton's body is just as vulnerable to destruction as any other construct, though destroying anautomaton coreis more difficult. As such, an automaton's soul might remain trapped within its core for years after the destruction of its body. This was the intent of the original creators, who hoped to provide functional immortality. However, in reality, the destruction of the body more often leads to a malfunction, requiring magical intervention such as resurrection magic to restore the automaton completely. In the case of the core's destruction, or if it malfunctions catastrophically enough that it can no longer hold the soul, the core releases the spirit to the River of Souls." };
            yield return new TextBlock { Id = Guid.Parse("08e259f0-27c2-484c-81f0-04f8b50a34d0"), Type = TextBlockType.Text, Text = "In some cases, an automaton can learn how to consciously or subconsciously influence its core. These automatons eventually learn how to release their souls from their cores, allowing their souls to move on when they feel they have achieved a satisfying life. This act leaves the automaton as a mindless construct, typically still active but no longer capable of anything but aimless wandering and occasional acts of self-defense." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("aa50d270-5fac-4ec6-a5ed-a57a3262c9dd"), Type = TextBlockType.Text, Text = "Due to the disparate fates of automatons, many of them lead solitary lives. There are a few cases of automatons originally designed to work together, such as groups of warriors, who remain as a team and dwell together in hideouts or travel together as wanderers. These groups are few and far between, however, and automaton settlements are even rarer. The only pockets of automatons that begin to resemble settlements typically hide among the ruins of Jistka. These groups can hold dozens of automatons, but any attempts to contact or visit them tend to be fruitless. Such gatherings are especially secretive, and the resident automatons will protect their homes at any cost." };
            yield return new TextBlock { Id = Guid.Parse("0c9a75f5-d837-414e-ba56-7df00df7c046"), Type = TextBlockType.Text, Text = "Automatons are far more likely to encounter other ancestries. Depending on the automaton's personality, this encounter could go a number of ways, ranging from extreme secrecy to open visitation. An automaton's unique appearance makes them stand out regardless of where they're found, but most others look upon them with awe or curiosity rather than fear. Magical constructs aren't an alien concept across Golarion, but many of them are mindless. After making it past the initial shock of a thinking construct, it's often not difficult for most grasp how to engage with an automaton. However, automatons are more likely to find the semblance of an everyday life in large cities like Absalom, Azir, or Quantium. Regardless of where they go, an automaton must remain on the lookout for those who would attempt to take their body for study or to access their core." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("16ba4c70-c690-42cc-9ee0-f6ab0a8886b3"), Type = TextBlockType.Text, Text = "The people of the Jistka Imperium saw theaeonsofAxisas ideal beings whose behavior was worthy of emulation, so many Jistkans were lawful neutral. Since many automatons contain Jistkan souls, most automatons are lawful neutral, or at least lawful in some capacity. Over the centuries, however, a fair number of automatons have drifted toward neutral alignments as their outlooks change without a primary society or set of ideals upon which to cling. Automatons tend to worship gods of technology or magic likeBrighandNethys, or variousmonitordemigods. Worship ofIroriandPharasmaare somewhat common among automatons as well. Pharasmin automatons likely learn how to release their souls from their cores, and often choose to do so. Though they are ancient beings from long before the time ofCasandalee, a small number of automatons have recognized the new artificial goddess as a kindred spirit." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("971720a7-5672-45a7-8c4f-c6b336a2212d"), Type = TextBlockType.Text, Text = "Many who became automatons had some role in society prior to their transformation and often gravitate toward classes that best represent these roles, even if they no longer remember their former life as more than subconscious flashes. Hunter, sharpshooter, and warrior automatons usually becomefighters,rangers, androgues. Spell casting classes, such asbards,witches, andwizardsare common among mage automatons. While an automaton can have any background, the pool of individuals chosen to become automatons were typically of theacolyte,bounty hunter,emissary,gladiator,guard,herbalist,hunter,martial disciple,scholar,scout, orwarriorbackground." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("2c92c161-9ffe-43af-a229-057199245c34"), Type = TextBlockType.Text, Text = "An automaton typically keeps the name they had before their transformation into a construct, if they can remember it. Even when other memories fade, memory of their name often remains. As such, many automatons have names with Jistkan origins. Second most common are automatons who had to give themselves a new name, as they lost their memories of the old one at some point. Those automatons that particularly believed in the cause of the Artificer Conclave might instead take the name of one of the conclave's members in honor of the cause that they gave their body to support. Some automatons prefer to change their names over their lifetimes, either selecting a new name from a culture they encountered or adding a title to represent a significant moment in their lives. In some cases an automaton will use a particularly cherished title in place of any other name." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Automaton Origins" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The method of creating automatons as the Artificer Conclave did millennia ago has been lost to time. As such, most automatons who remain on Golarion were created during Jistka's existence. However, there are a few rare automatons that have different origins. Anquira, herself an automaton and a high-ranking member of the Artificer Conclave, resides in Axis and seems to be nearing the point of recreating the Jistkan process. She's created a few promising prototype automatons with her techniques. There are also rumors of another automaton doing similar research somewhere in the deserts of the Golden Road, though the new automatons emerging from the desert appear somewhat incomplete." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Of significant note are the increased reports of automatons in southern Garund, originating from the nation of Eihlona. The nation is famous for its inhabitants' skill in mixing magic with technology, particularly the remnants of Shory technology that crashed within the nation's borders in ages past. Eihlonan mage crafters have managed to recreate automatons using their vast knowledge, magical prowess, and access to ancient technology, alongside insights from a few friendly automaton immigrants who found a respectful and welcoming home there. Though the process is long and arduous, Eihlona seems to be on the verge of recreating the success of the Artificer Conclave. If they do, they could someday produce hundreds, if not thousands of automatons." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Enhancements" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Automatons are built to receive enhancements and modifications to their bodies. Many automaton ancestry feats have an “Enhancement” line that represents a possible augmentation you can acquire. You don't gain the benefits of the enhancement unless you take a feat that grants you those benefits, such as Lesser Augmentation. You can only gain the enhancements of a given feat once." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Versatile Heritages" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Since automatons have artificial bodies, they don't manifest the features of versatile heritages, even if the soul within their core did so in life. As a result, most automatons don't have a versatile heritage. However, players who are interested in taking a versatile heritage are encouraged to speak with their GM to best determine an explanation for the versatile heritage. Since an automaton core draws on planar energy, there is a chance that said energy manifests in a versatile heritage, such as a tiefling automaton with an overabundance of Hell's planar energy. Alternatively, a powerful soul might still be able to manifest the features of their heritage they had prior to transfer to an automaton body. An automaton with a versatile heritage will have minimal physical changes if any, though the color of energy that courses through their core and the rest of their body might change to properly represent the versatile heritage." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Automaton Core" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your body contains an automaton core infused with planar quintessence that grants you power to perform various tasks and houses your soul and life energy. This life energy flows through you much like the blood of humanoids. As a result, you are a living creature. You don't have the typical construct immunities, can be affected by effects that target a living creature, and can recover Hit Points normally via positive energy. Additionally, you are not destroyed when reduced to 0 Hit Points. Instead, your life energy attempts to keep you active even in dire straits; you are knocked out and begin dying when reduced to 0 Hit Points." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Constructed Body" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your physiological needs are different than those of living creatures. You don't need to eat or drink. You don't need to sleep, but you still need a daily period of rest. During this period of rest, you must enter a recuperating standby state for 2 hours, which is similar to sleeping except you are aware of your surroundings and don't take penalties for being unconscious. Much like with sleeping, if you go too long without entering your standby state, you become fatigued and can't recover until you enter standby for 2 hours." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
            yield return Traits.Instances.Automaton.ID;
            yield return Traits.Instances.Construct.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("eae09dfb-637d-45bf-86a5-f0903a426669"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("28a2040a-0222-47cd-a24d-f8779156e274"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("cccb3fe2-4275-469e-a95b-700e4c4bf781"), Stats.Instances.Strength.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("5009f1ca-4518-4d39-94cd-5f3c8056d932"));
            builder.GainSpecificLanguage(Guid.Parse("a144e7f8-0867-40c4-8d02-48be96e275ec"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("407a6b70-1a6f-4736-8b26-533549f50e11"), Languages.Instances.Utopian.ID);
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            //TODO: Add intelligence modifier languages.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fd3a35be-984b-4677-bbb2-f6fc0f2581fb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 37
            };
        }
    }
}
