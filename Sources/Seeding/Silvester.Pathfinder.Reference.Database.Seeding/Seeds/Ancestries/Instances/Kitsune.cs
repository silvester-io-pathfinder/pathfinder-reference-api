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
    public class Kitsune : Template
    {
        public static readonly Guid ID = Guid.Parse("17964ea7-a16d-4a89-a97e-593ad804fbf3");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Kitsune", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Common.ID, 
                SampleNames = "Hamako, Haohiko, Kitsukou, Kon, Kwan-la, Talaro"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("53307d29-1bc3-4681-8b44-38d14f0fede8"), Type = TextBlockType.Text, Text = "Kitsune are a charismatic and witty people with a connection to the spiritual that grants them many magical abilities, chiefly the power to shapechange into other forms. Whether they pass unseen among other peoples or hold their tails high, kitsune are clever observers of the societies around them." };
            yield return new TextBlock { Id = Guid.Parse("10fbf73f-f44c-4d47-975d-051b25105141"), Type = TextBlockType.Text, Text = "Kitsune are shapechangers with two forms: one of a fox-headed humanoid and one largely depending on where they were raised. Those raised in populated areas typically have what's called a tailless form—a humanoid body without any fox features that resembles a more common ancestry, such as an elf or a human. In wooded or rural areas, their second form is more likely to be that of a fox." };
            yield return new TextBlock { Id = Guid.Parse("11e85c90-3e54-4639-819e-798c995849c5"), Type = TextBlockType.Text, Text = "Though all-kitsune settlements exist, most live among people of other ancestries, granting them a degree of external insight into social rules or dynamics that others process only subconsciously. Kitsune enjoy subverting expectations as much as they do going along with them. Their fondness for jokes, stories, and wordplay, especially when the twist of a riddle hinges on the listener's assumptions, reinforces their reputation as tricksters." };
            yield return new TextBlock { Id = Guid.Parse("1c18be8f-c035-4bf1-8b78-67910a340f50"), Type = TextBlockType.Text, Text = "With dual forms and a connection to both the material and spiritual worlds, kitsune have diverse concepts of self and identity. Some even view their forms as separate individuals altogether, using them to explore different aspects of their personality." };
            yield return new TextBlock { Id = Guid.Parse("0affe8c7-1a92-49c8-a5a9-71a5ca77358a"), Type = TextBlockType.Text, Text = "If you want to play a character with innate magical talents and countless hidden facets, each revealed with a glint of the eye and a twisting grin, you should play a kitsune." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("5f0e6e84-2dd3-4c9d-9445-becbb8a384f9"), Type = TextBlockType.Enumeration, Text = "Studiously observe the habits of those around you, taking mental notes on how to imitate them better." };
            yield return new TextBlock { Id = Guid.Parse("80fc0e12-333b-49ee-a42d-ef809ac78cac"), Type = TextBlockType.Enumeration, Text = "Delight in jokes, clever wordplay, pranks, or unnecessarily complex plots." };
            yield return new TextBlock { Id = Guid.Parse("b4855d55-a28f-4524-b38c-fce58549809f"), Type = TextBlockType.Enumeration, Text = "Present a different, but authentic, side of yourself in each new situation." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("f5b4597f-df98-468c-9ca2-f36a8d5f0a2b"), Type = TextBlockType.Enumeration, Text = "Are taken in by your magnetic personality and enigmatic nature." };
            yield return new TextBlock { Id = Guid.Parse("4a33732c-8a08-4837-a805-44034a560b48"), Type = TextBlockType.Enumeration, Text = "Marvel at your many supernatural abilities." };
            yield return new TextBlock { Id = Guid.Parse("533e6de4-92c7-4ff2-9a44-715d5a1c1f77"), Type = TextBlockType.Enumeration, Text = "Wonder what you aren't telling them." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("a8d79e72-18c3-4de1-aaef-193eef059c00"), Type = TextBlockType.Text, Text = "Kitsune have alert vulpine ears, pointed snouts, and short, semi-retractable claws on their fingers and toes. Their fur is dense, countershaded, and most often red, tan, black, or white in color. Kitsune have bushy tails that grow in number as they hone their innate magical abilities, to as many as nine." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("9cc8df60-e2c6-4ad2-a00e-88c7540ae006"), Type = TextBlockType.Text, Text = "Kitsune are rarely the majority in whatever communities they inhabit, and many go their whole lives without meeting another kitsune beyond their family. Their society, as much as it exists, centers primarily around the commonalities that kitsune find as they pass among other peoples. The same social perspective that helps them imitate others also makes them quick to notice signs that someone may need help or a kind word. Due to this, kitsune often form strong interpersonal relationships and tend to anchor their social circles." };
            yield return new TextBlock { Id = Guid.Parse("16a8cb75-9f95-4d8c-9841-c05bed53ff43"), Type = TextBlockType.Text, Text = "When two kitsune do meet, they may find themselves exchanging light verbal repartee, enjoying the sport of trying to outwit each other. While it's considered a grave offense to outright give away another kitsune's shapechanging nature, kitsune relish surreptitiously forcing another to “break character,” shocking the other into disrupting their transformation through a well-placed comment." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("4e9b60dd-aac9-4852-ae57-268d4a1a1fb2"), Type = TextBlockType.Text, Text = "Kitsune often have neutrality in their alignment from balancing their dual natures, though their instinct for stirring up trouble leads many to lean slightly toward chaos. Some possess the ability to control or bend the will of others, but even among those that do, only the evilest use these arts flippantly or selfishly. The patron kitsune deity isDaikitsu, the goddess of crafting and agriculture. Though not all kitsune necessarily worship Daikitsu, most respect her as the purported source of their powers. Kitsune in Tian Xia often revere bothShizuruandTsukiyo, seeing the duality of the sun and moon in their own multifaceted nature. A small sect of Avistani kitsune worshipSivanah, the goddess of illusion, respecting her position between perception and reality and believing the goddess's true form to be that of a kitsune—hidden behind not seven veils, but nine." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("474fd903-8d34-40ff-ac9c-2406a3179fc5"), Type = TextBlockType.Text, Text = "Kitsune who live among others often have thecharlatan,emissary,entertainer,fortune teller,merchant,noble, ornomadbackgrounds. Those kitsune who strike out alone favor theacolyte,bandit, orhermitbackgrounds. Kitsune often excel asrogues,investigators, andbards. Kitsune who hone their magical abilities lean more towardsorcerersororacles, and those who forge a stronger connection to the spirits may becomewitches." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("05e66232-0e3d-4b4d-805d-78d128a94299"), Type = TextBlockType.Text, Text = "While kitsune have some traditional names, they're more likely to use names that are unremarkable in their local society, the better to pass unnoticed. Some have different names for each form: a kitsune name for their kitsune form, a regional name for a tailless form, and possibly no name at all for a fox form." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse("8beef227-cb93-490d-b706-6cf4091b8079"), Type = TextBlockType.Heading, Text = "Fox Families" };
            yield return new TextBlock { Id = Guid.Parse("5c3335cf-91c2-4171-bb0f-5c931e630a0f"), Type = TextBlockType.Text, Text = "Due to their shifting nature, kitsune often have mixed-ancestry family units. The children of a kitsune and a non-kitsune can inherit either of their parent's lineages, though many assume that a human baby born to a kitsune is simply a kitsune that has yet to reveal their true form. This has led to the widespread misconception that all offspring of kitsune are themselves kitsune." };

            yield return new TextBlock { Id = Guid.Parse("85385ff1-9d32-4fe0-84c0-439f5e90ac3e"), Type = TextBlockType.Heading, Text = "Kitsune Settlements" };
            yield return new TextBlock { Id = Guid.Parse("8b74fb6c-62cf-4bc3-9a9d-9d063bc05e82"), Type = TextBlockType.Text, Text = "Though kitsune live all around the world, two major kitsune settlements exist on Golarion: Kihime in Tian Xia, and Angen in the Inner Sea region. Kihime, the central settlement for Souko kitsune, is located in the Forest of Spirits and consists of low, thatched buildings in an intentionally ancient, though effective, design. Rather than torches, star orbs line the streets and glow with soft foxfire to light the darkness—legends state that these star orbs can be unified to cloak Kihime in illusions and abjurations in times of peril. Angen, in the Verduran Forest of Taldor, represents a more modern and cosmopolitan kitsune town, with buildings made in a variety of styles. Angen customs emphasize unity and collectivism, one of the best known being the Foxes' Wedding. In this yearly festival, which occurs spontaneously on the first autumn day that rain falls from a blue sky, all kitsune who became betrothed in the last year are considered married. In celebration, rainbows formed from the mixed sunlight and raindrops are enhanced by kitsune illusions, becoming truly a sight to behold." };

            yield return new TextBlock { Id = Guid.Parse("295ab583-1c0a-4ca6-aada-a9bc3d407c4b"), Type = TextBlockType.Heading, Text = "The Lady of Foxes" };
            yield return new TextBlock { Id = Guid.Parse("b6ba015a-f856-418e-8646-2a402030174b"), Type = TextBlockType.Text, Text = "Though usually referred to with she/her pronouns, the goddess Daikitsu's nature is fluid; her gender, age, and appearance change at her whim. Kitsune's legends state that they were created when Daikitsu granted her original attendants, fox spirits known as the Nine Bright Grains, one of her own abilities: the power to dance between shapes." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse("6c3eb3c9-dd5a-4213-a3b6-40e2bb787b1c"), Type = TextBlockType.Heading, Text = "Change Shape" };
            yield return new TextBlock { Id = Guid.Parse("7f801a44-6e2b-4849-b405-b39fc5f06e18"), Type = TextBlockType.Text, Text = "As a kitsune, you gain the Change Shape ability." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Kitsune.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("af2e68e6-094c-475a-8363-7307752fd2f1"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("d62b648e-466f-4909-b599-16afc8f4cf50"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("637a51f7-a113-4aaa-9319-b801b869f467"), Stats.Instances.Charisma.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("b80aacc5-df44-4e51-aec2-fa90b4940fae"));
            builder.GainSpecificLanguage(Guid.Parse("c1c516af-d11b-4e1e-b1e8-0000096d6d33"), Languages.Instances.Common.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificFeat(Guid.Parse("29e08d86-c028-4bdd-96f8-efcba2692698"), Feats.Instances.ChangeShapeKitsune.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bcebee12-bbcd-414c-b8f3-22c9e3287b81"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 121
            };
        }
    }
}
