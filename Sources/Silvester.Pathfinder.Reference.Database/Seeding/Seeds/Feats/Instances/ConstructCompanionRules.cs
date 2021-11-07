using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConstructCompanionRules : Template
    {
        public static readonly Guid ID = Guid.Parse("3b8cec12-90bf-4dcf-9e05-6dfcbf7351f9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Construct Companion Rules",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("53a1ed2f-5211-4c63-9ab0-aa3ff9a4bd3f"), Type = TextBlockType.Text, Text = "A construct companion is a loyal semi-sentient construct who follows your orders obediently and is roughly as intelligent as an animal. Your construct companion has the (trait: minion) trait, and it gains 2 actions during your turn if you use the (action: Command a Minion | Command an Animal) action to command it." };
            yield return new TextBlock { Id = Guid.Parse("5b52c2e5-1c12-444d-839e-98ac5c366f19"), Type = TextBlockType.Text, Text = "If your companion is destroyed, you can spend 1 day of downtime and attempt a Crafting check with a high DC for your level. On a success, you rebuild your companion. You can have only one construct companion at a time, and you can have either a construct companion or an animal companion, but not both." };
            yield return new TextBlock { Id = Guid.Parse("f2693c01-6216-40ce-8a49-39db4fcc6d54"), Type = TextBlockType.Enumeration, Text = "**Riding Construct Companions***" };
            yield return new TextBlock { Id = Guid.Parse("bd55421b-4d0c-4fe6-964d-1782ce22954e"), Type = TextBlockType.Text, Text = "You or an ally can ride your construct companion as long as your construct companion is at least one size larger than the rider." };
            yield return new TextBlock { Id = Guid.Parse("e1609008-e00a-4569-8cdd-20db3fdf107c"), Type = TextBlockType.Enumeration, Text = "**Prototype Construct Companions***" };
            yield return new TextBlock { Id = Guid.Parse("9ab979ed-50d2-452f-9ad5-7ce31ad00660"), Type = TextBlockType.Text, Text = "The following are the base statistics for a prototype construct companion, the first construct companion most characters get. A companion has the same level you do. As you gain levels, you might make further adjustments as your companion grows more powerful. Construct companions calculate their modifiers and DCs just as you do, with one difference: the only item bonuses they can benefit from are to Speed." };
            yield return new TextBlock { Id = Guid.Parse("4f117678-90c4-465e-853a-059a634c3a63"), Type = TextBlockType.Enumeration, Text = "*Construct Trait**" };
            yield return new TextBlock { Id = Guid.Parse("a073805c-378b-4dff-9d45-6fabb63b85a8"), Type = TextBlockType.Text, Text = "A construct companion has the (trait: construct) trait. It’s not a living creature, nor is it undead." };
            yield return new TextBlock { Id = Guid.Parse("9be93e90-1fa6-4b3e-b837-8bf30ca594b9"), Type = TextBlockType.Enumeration, Text = "*Proficiencies**" };
            yield return new TextBlock { Id = Guid.Parse("5cb5f570-aa86-48ae-9d96-be49dee89053"), Type = TextBlockType.Text, Text = "Your construct companion is trained in its unarmed attacks, unarmored defense, all saving throws, Perception, Acrobatics, and Athletics. Construct companions can’t use abilities that require greater Intelligence, such as Coerce or Decipher Writing, even if trained in the appropriate skill, unless they have an ability that allows it." };
            yield return new TextBlock { Id = Guid.Parse("5c53b3e4-084d-444d-bcda-7fc56c2aea65"), Type = TextBlockType.Enumeration, Text = "*Size**" };
            yield return new TextBlock { Id = Guid.Parse("a9e8eb24-c47d-4c99-aee4-ea580b85ffe4"), Type = TextBlockType.Text, Text = "Your construct companion is either Small or Medium, chosen by you when you first gain the companion." };
            yield return new TextBlock { Id = Guid.Parse("b2f25cd2-63f0-48ca-9368-9301c0e11dd0"), Type = TextBlockType.Enumeration, Text = "*Strikes**" };
            yield return new TextBlock { Id = Guid.Parse("9731885b-cabf-4a6a-b5ff-41728cda2276"), Type = TextBlockType.Text, Text = "Your construct companion has two kinds of melee unarmed attacks. Its first unarmed attack deals 1d8 bludgeoning damage. Depending on the shape of your construct this could be a fist, tendril, or other similar unarmed attack. Its other unarmed attack deals 1d6 slashing or piercing damage (choose when you first gain the companion) and has the agile and finesse traits. Depending on the shape of your construct, this could be a spine or spike, jaws or fangs, a retractable blade, or other similar unarmed attack." };
            yield return new TextBlock { Id = Guid.Parse("6060d1eb-4c8d-42f1-a429-484d08c37912"), Type = TextBlockType.Enumeration, Text = "*Ability Modifiers**" };
            yield return new TextBlock { Id = Guid.Parse("04689e6d-24ee-453b-8908-fa0b940841fe"), Type = TextBlockType.Text, Text = "A construct companion begins with base ability modifiers of Str +3, Dex +3, Con +2, Int –4, Wis +1, Cha +0." };
            yield return new TextBlock { Id = Guid.Parse("30aa4dcb-5e33-41a6-844d-1373a0405f11"), Type = TextBlockType.Enumeration, Text = "*Hit Points**" };
            yield return new TextBlock { Id = Guid.Parse("825b8f36-7d85-49a6-96a3-36f93569e4b5"), Type = TextBlockType.Text, Text = "Your construct companion has 10 Hit Points, plus a number of Hit Points equal to 6 plus its Constitution modifier for each level you have." };
            yield return new TextBlock { Id = Guid.Parse("55b7a9a7-6245-47b7-b0fd-39d52390ee52"), Type = TextBlockType.Text, Text = "While constructs are usually immediately destroyed at 0 Hit Points, your construct companion is a little harder to destroy than other constructs are. When your construct reaches 0 Hit Points, it becomes broken and begins sparking and might be destroyed if you don’t Repair it. This works the same as the normal dying rules and determines if your construct is destroyed, with the following two changes. First, most effects that end the dying condition don’t work to save a construct companion, but a construct can be stabilized using the Administer First Aid action, using the Crafting skill instead of Medicine. Second, instead of gaining and tracking the wounded condition, if your construct becomes broken in this way more than twice within a 10-minute period, it’s destroyed, and you’ll need to reconstruct it by spending a day of downtime." };
            yield return new TextBlock { Id = Guid.Parse("8db761dc-c043-482e-a4de-91db2ca183d5"), Type = TextBlockType.Enumeration, Text = "*Immunities**" };
            yield return new TextBlock { Id = Guid.Parse("74aa45e9-b631-4e0d-8c72-7eff104122c7"), Type = TextBlockType.Text, Text = "Because it’s a construct, your construct companion is immune to bleed, death effects, disease, doomed, drained, fatigued, healing, necromancy, nonlethal attacks, paralyzed, poison, sickened, and unconscious. Because the construct isn’t a living creature, effects that heal living creatures can’t help it recover Hit Points. Restoring Hit Points to it requires using the Repair action or other means that can restore Hit Points to objects and nonliving creatures." };
            yield return new TextBlock { Id = Guid.Parse("b444521e-f245-4960-969b-0f55fcf8a0db"), Type = TextBlockType.Enumeration, Text = "*Senses**" };
            yield return new TextBlock { Id = Guid.Parse("79332cc4-987b-413f-9646-08704b281aa9"), Type = TextBlockType.Text, Text = "Your construct companion has precise vision, imprecise hearing, and vague touch senses, but no sense of smell or taste." };
            yield return new TextBlock { Id = Guid.Parse("62ef7255-0067-4e49-8e87-da2913ff8db3"), Type = TextBlockType.Enumeration, Text = "*Speed**" };
            yield return new TextBlock { Id = Guid.Parse("41de9926-9a5a-4200-b5a8-ad421334010a"), Type = TextBlockType.Text, Text = "Your construct companion has a Speed of 25 feet." };
            yield return new TextBlock { Id = Guid.Parse("d8d478e1-edc4-4d96-92f9-a63aeb149eeb"), Type = TextBlockType.Enumeration, Text = "**Advanced Construct Companions***" };
            yield return new TextBlock { Id = Guid.Parse("28d52828-b9e8-4e5f-b109-f38cf51ed212"), Type = TextBlockType.Text, Text = "To advance a prototype construct companion to an advanced construct companion (usually a result of one of your class feat choices), make the following adjustments." };
            yield return new TextBlock { Id = Guid.Parse("2a400242-e0cf-400c-85d7-0ce633a5240d"), Type = TextBlockType.Enumeration, Text = " : Increase its Strength, Dexterity, Constitution, and Wisdom modifiers by 1." };
            yield return new TextBlock { Id = Guid.Parse("56987acb-c25d-49ca-b7b1-e8e3f4d9ded3"), Type = TextBlockType.Enumeration, Text = " : Increase its unarmed attack damage from one die to two dice (for instance, 1d8 to 2d8)." };
            yield return new TextBlock { Id = Guid.Parse("babeaabd-bfec-4136-8559-f6272c0e733e"), Type = TextBlockType.Enumeration, Text = " : Increase its proficiency rank for Perception and all saving throws to expert." };
            yield return new TextBlock { Id = Guid.Parse("2fd1f7d4-846d-444f-a0e4-b18c8963f859"), Type = TextBlockType.Enumeration, Text = " : Increase its proficiency ranks in Intimidation, Stealth, and Survival to trained. If the construct is your innovation and it was already trained in those skills from a modification, increase its proficiency rank in those skills to expert." };
            yield return new TextBlock { Id = Guid.Parse("4add5b1f-5329-4312-97ce-67602bc47180"), Type = TextBlockType.Enumeration, Text = " : You can change your companion’s Size, if you want, to either Small, Medium, or Large." };
            yield return new TextBlock { Id = Guid.Parse("2e07f34d-cc98-4237-994d-fbbb29130bca"), Type = TextBlockType.Enumeration, Text = "**Incredible Construct Companions***" };
            yield return new TextBlock { Id = Guid.Parse("58ce9b89-f59b-4571-8806-aaef2ea16b03"), Type = TextBlockType.Text, Text = "To improve an advanced construct companion to an incredible construct companion, make the following adjustments." };
            yield return new TextBlock { Id = Guid.Parse("278a1b8c-b3e5-458e-a2fb-eb9fad7f79dc"), Type = TextBlockType.Enumeration, Text = " : Increase its Strength, Dexterity, Constitution and Wisdom modifiers by 2." };
            yield return new TextBlock { Id = Guid.Parse("927baf6f-ab59-420f-89d5-86c46d53154e"), Type = TextBlockType.Enumeration, Text = " : It deals 2 additional damage with its unarmed attacks. Its attacks become magical, allowing it to bypass resistances to non-magical attacks." };
            yield return new TextBlock { Id = Guid.Parse("8829443f-3904-4021-9612-2a11632775d2"), Type = TextBlockType.Enumeration, Text = " : Increase its proficiency ranks in Athletics and Acrobatics to expert." };
            yield return new TextBlock { Id = Guid.Parse("9a981fe1-bf5d-4a2b-8fbb-24f7191819d5"), Type = TextBlockType.Enumeration, Text = "**Paragon Construct Companions***" };
            yield return new TextBlock { Id = Guid.Parse("4ea22298-ae02-4804-a9ed-65f7ac1c989a"), Type = TextBlockType.Text, Text = "To improve an incredible construct companion to a paragon construct companion, make the following adjustments." };
            yield return new TextBlock { Id = Guid.Parse("3e4a3355-10f6-4d70-bcc7-8a9f9e3d5819"), Type = TextBlockType.Enumeration, Text = " : Increase its Strength, Dexterity, Constitution, and Wisdom modifiers by 1." };
            yield return new TextBlock { Id = Guid.Parse("352d5d29-acf3-464d-9146-b991d6e98db6"), Type = TextBlockType.Enumeration, Text = " : Increase its proficiency rank for unarmed attacks and unarmored defense to expert." };
            yield return new TextBlock { Id = Guid.Parse("5184da60-b321-4e73-90ee-93694f16be07"), Type = TextBlockType.Enumeration, Text = " : Increase its proficiency ranks for Athletics, Acrobatics, saving throws, and Perception to master." };
            yield return new TextBlock { Id = Guid.Parse("5c3d1f8a-ff53-4d36-8a36-3c2b55693bca"), Type = TextBlockType.Enumeration, Text = " : Increase its unarmed attack damage from two dice to three dice, and its additional damage with unarmed attacks from 2 to 4." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f11439ef-abe7-4f5a-9ace-0853e37d40f4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
