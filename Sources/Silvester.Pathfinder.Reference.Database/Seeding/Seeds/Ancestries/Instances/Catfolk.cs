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
    public class Catfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("ec22df82-0b4f-478c-a951-9b31253ef69a");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Catfolk", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SampleNames = "Alyara, Crinto, Drewan, Espes, Ferrus, Gerran, Halhat, Hoya, Ruun, Sevastin, Tespa, Yonsol, Zakkar, Zathra"
            };
        }

        protected override IEnumerable<Guid> GetSizes()
        {
            yield return AncestrySizes.Instances.Medium.ID;
        }

        protected override IEnumerable<TextBlock> GetDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("85de7357-fd6d-4ca7-88da-cbe283825e1e"), Type = TextBlockType.Text, Text = "Curious and gregarious wanderers, catfolk combine features of felines and humanoids in both appearance and temperament. They enjoy learning new things, collecting new tales and trinkets, and ensuring their loved ones are safe and happy. Catfolk view themselves as chosen guardians of natural places in the world and are often recklessly brave, even in the face of overwhelming opposition." };
            yield return new TextBlock { Id = Guid.Parse("764d4352-8c84-4187-90e8-9b65d7d6c16d"), Type = TextBlockType.Text, Text = "Catfolk are outgoing, active humanoids who delight in discovery, whether of hidden ruins or a comfortable place to nap. They are exceptionally social, both within their tight-knit communities and with other creatures they meet. Remarkably brave, catfolk see themselves as guardians of the world against forces that would assail it, and they believe that strong communities, breadth of experience, and continual self-improvement aid them in this fight." };
            yield return new TextBlock { Id = Guid.Parse("73afe94e-3c3c-40b8-b3fd-5e17eccf8db6"), Type = TextBlockType.Text, Text = "Catfolk have fast reflexes and are even able to twist themselves in the air while falling to land on their feet. As quick as these reflexes are, catfolk have quicker tempers, shifting from effusive glee to aggrieved fury in an instant. Like mundane felines, catfolk involuntarily purr when pleased and growl when surprised or angry." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you want a character who is curious, brave, friendly, and nimble in body and mind, you should play a catfolk." };
        }

        protected override IEnumerable<TextBlock> GetYouMight()
        {
            yield return new TextBlock { Id = Guid.Parse("3aa707df-f269-4138-8e2e-30c3426a3a07"), Type = TextBlockType.Enumeration, Text = "Demonstrate genuine interest by asking a lot of enthusiastic questions. " };
            yield return new TextBlock { Id = Guid.Parse("01d358c1-3f0c-402a-b351-2edf1cf8020a"), Type = TextBlockType.Enumeration, Text = "Avoid interpersonal conflict by giving someone a cold shoulder or by simply leaving the area. " };
            yield return new TextBlock { Id = Guid.Parse("12d5655d-fd83-44d3-8ef3-e2cf5a840987"), Type = TextBlockType.Enumeration, Text = "Carefully scout a target or problem before striking at it quickly." };
        }
    
        protected override IEnumerable<TextBlock> GetOthersProbably()
        {
            yield return new TextBlock { Id = Guid.Parse("a0204703-1ea5-4b36-97e2-a1bcc173904f"), Type = TextBlockType.Enumeration, Text = "Think you monopolize conversations with your incessant queries or opinions. " };
            yield return new TextBlock { Id = Guid.Parse("385e4f42-9170-4a40-a9d1-5195e52f51ab"), Type = TextBlockType.Enumeration, Text = "Consider you haughty or prideful. " };
            yield return new TextBlock { Id = Guid.Parse("18c3a5c7-3dc0-4a7d-8357-ed99745ed8d8"), Type = TextBlockType.Enumeration, Text = "Ascribe more emotion than you feel to your involuntary purrs or growling." };
        }
    
        protected override IEnumerable<TextBlock> GetPhysicalDescription()
        {
            yield return new TextBlock { Id = Guid.Parse("480656aa-b340-4406-a5cd-3f3043c2a8a2"), Type = TextBlockType.Text, Text = "Although all catfolk walk upright and have soft fur, a long tail, large ears, and vertical pupils, they show at least as much variety as ordinary felines. Catfolk have nimble fingers with short claws that are usually retractable. Most catfolk take great pride in maintaining their appearance and rarely suffer the indignity of being wet or dirty if they can avoid it." };
            yield return new TextBlock { Id = Guid.Parse("fa70d953-cf79-40da-aab7-a829f74e152c"), Type = TextBlockType.Text, Text = "Catfolk mature quickly and are able to walk at only a few months old, but they otherwise start their careers at roughly the same age as humans do and live to be 60 or 70 years of age. Catfolk are rarely taller than the average human and, because of their lean builds, almost never weigh as much as a human of similar height." };
        }
    
        protected override IEnumerable<TextBlock> GetSociety()
        {
            yield return new TextBlock { Id = Guid.Parse("66620d7f-de70-45e7-9e62-7294bdd43ffd"), Type = TextBlockType.Text, Text = "Catfolk call themselves amurruns, although many consider this name to be private. They raise their children in large extended families, where they are given what many other humanoids see as a distressing latitude to explore and get into trouble from a remarkably young age. Catfolk learn a trade in a loose apprenticeship, and the majority learn several trades over their lives." };
            yield return new TextBlock { Id = Guid.Parse("c0563e17-f3be-47c1-b971-a425aef02f45"), Type = TextBlockType.Text, Text = "Catfolk societies are often led by an appointed leader who speaks on behalf of the community and mediates disputes. A catfolk leader is most often a spellcaster and usually female. Catfolk prefer to deal with grievances by making an elaborate showing of disinterest, or even leaving a community for a time so the problem can die away or work itself out." };
        }
    
        protected override IEnumerable<TextBlock> GetAlignmentAndReligion()
        {
            yield return new TextBlock { Id = Guid.Parse("eed52890-6801-4248-8794-f1d1d6424bf4"), Type = TextBlockType.Text, Text = "Catfolk aren’t a particularly religious people, but most do believe they were uplifted from great primeval cats to confront the evil abominations despoiling natural places and laboring to unmake reality. The gods blessed catfolk with language, the use of tools and weapons, and a strong sense of community." };
            yield return new TextBlock { Id = Guid.Parse("607dafaa-d3b8-4e9d-bbde-defb6f9ac245"), Type = TextBlockType.Text, Text = "Most catfolk are good. They enjoy the freedom to travel and like to set their own paths in life, so more catfolk are chaotic than lawful. Religious catfolk most often practice a nebulous form of animism, appeasing the spirits of the land and the creatures they hunt to preserve the natural order." };
        }
    
        protected override IEnumerable<TextBlock> GetAdventurers()
        {
            yield return new TextBlock { Id = Guid.Parse("dea6db91-7b8c-4402-b301-76f80b12239f"), Type = TextBlockType.Text, Text = "Catfolk delight in venturing into unexplored areas, whether untrammeled wildernesses or ancient dungeons. They like finding treasures and baubles, but for most catfolk, the experience of the journey itself is the true reward." };
            yield return new TextBlock { Id = Guid.Parse("78701e65-9e0d-4c48-a8db-61a99a190561"), Type = TextBlockType.Text, Text = "Typical catfolk backgrounds includeacrobat,artist,gambler,hunter,nomad, andscoutfrom theCore Rulebook, plusbandit,courier,insurgent,outrider, androot workerfrom this book. Catfolk’s inherent curiosity and agility mean they excel asswashbucklers,bards,fighters, androgues. Their love of the natural world and drive to puzzle out secrets of all types leads many to become investigators, druids, or sorcerers." };
        }
    
        protected override IEnumerable<TextBlock> GetNames()
        {
            yield return new TextBlock { Id = Guid.Parse("55493182-98e9-429d-8589-826578409962"), Type = TextBlockType.Text, Text = "Catfolk are given short names in their youth. Adolescent catfolk are free to choose a different name when they first leave home, though some simply keep the name they’ve gotten used to. Catfolk love to add titles and honorifics to their names. Some catfolk use their titles exclusively among non-catfolk, and so become known by epithets like Six Fates, Fiend Killer, or Mistcloak." };
        }
    
        protected override IEnumerable<TextBlock> GetOtherInformation()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Catfolk Luck" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Catfolk are known for their luck, which they traditionally draw from spirits of creation that they've pleased or emulated. Many catfolk tend to experience this luck as an insistent urge that feels like a warning from a benevolent presence they can't perceive. Others experience it as a reflexive awareness of danger beyond their normal senses. More spiritual catfolk try to tune into the warnings from the spirits of fortune through an art known as serendipity reading." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Murraseth" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Murraseth is the largest of several remote catfolk-majority city-states in central Garund. Even distant catfolk take pride in its guilds and its Houses of Names—labyrinthine, live-in galleries for artists and performers who retell catfolk discoveries and tales. Many catfolk consider visiting a House of Names an important life milestone." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Guilds dominate Murraseth. Perhaps the most distinctive of these groups is the Circle of Lifeshapers, comprised of polymorph specialists and healers." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Other Catfolk" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Numerous catfolk ethnicities exist beyond the Inner Sea. The black-spotted Guarrxil of southern Arcadia are renowned for their principled mercenary companies and heroic rangers. The mysterious Caimurru of the western Arcadian coast trade more with First World caravans than with other mortals. The Lyashtaki catfolk of the Valashmai Jungle sometimes make treks far from the jungle via coast-hopping boats." };
        }

        protected override IEnumerable<TextBlock> GetAdditionalMechanics()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Land on your Feet" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you fall, you take only half the normal damage and don't land prone." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Catfolk.ID;
            yield return Traits.Instances.Humanoid.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificHitpoints(Guid.Parse("5286029b-a0d9-456a-97c5-50f0cdf48202"), ModifierType.Add, modifier: 8);
            builder.ModifySpecificSpeed(Guid.Parse("48db70af-31d3-4a20-a0b5-06b60c8af7d5"), MovementMethod.Walking, ModifierType.Add, modifier: 25);
            builder.GainSpecificAbilityBoost(Guid.Parse("e2484afd-20c8-4bcf-86a6-337a625e2c37"), Stats.Instances.Dexterity.ID);
            builder.GainSpecificAbilityBoost(Guid.Parse("cb0022d7-0568-42d9-af73-165577112523"), Stats.Instances.Charisma.ID);
            builder.GainAnyAbilityBoost(Guid.Parse("c6b14968-2030-4ded-83ab-b432857aba5d"));
            builder.GainSpecificAbilityFlaw(Guid.Parse("55381db2-6bbb-4d8b-a8cf-8cebe92ab729"), Stats.Instances.Wisdom.ID);
            builder.GainSpecificLanguage(Guid.Parse("fc4aa77a-bbb5-4d15-bc2f-1889d1ef1f58"), Languages.Instances.Common.ID);
            builder.GainSpecificLanguage(Guid.Parse("90def073-b454-492d-9d04-101a4970498b"), Languages.Instances.Amurrun.ID);
            //TODO: Add intelligence modifier languages.
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.ModifyFallDistance(Guid.Parse(""), ModifierType.Divide, modifier: 2);
            //TODO: Add the none-prone effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3849bfe2-7744-4042-9cd7-1d05cf82dcc0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 9
            };
        }
    }
}
