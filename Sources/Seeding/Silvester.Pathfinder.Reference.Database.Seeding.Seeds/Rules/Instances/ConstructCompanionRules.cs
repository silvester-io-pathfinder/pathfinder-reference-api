using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Rules.Instances
{
    public class ConstructCompanionRules : Template
    {
        public static readonly Guid ID = Guid.Parse("3676682f-0270-4074-a504-896f80834742");

        protected override Rule GetRule()
        {
            return new Rule
            {
                Id = ID,
                Name = "Construct Companion Rules",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4e5ad5d5-a924-4baf-82cf-9668204a7020"), Type = TextBlockType.Text, Text = $"A construct companion is a loyal semi-sentient construct who follows your orders obediently and is roughly as intelligent as an animal. Your construct companion has the {ToMarkdownLink<Models.Entities.Trait>("minion", Traits.Instances.Minion.ID)} trait, and it gains 2 actions during your turn if you use the {ToMarkdownLink<Models.Entities.SkillAction>("Command a Minion", SkillActions.Instances.CommandAnAnimal.ID)} action to command it." };
            yield return new TextBlock { Id = Guid.Parse("18de6875-9442-433a-a36e-31443c686ecd"), Type = TextBlockType.Text, Text = $"If your companion is destroyed, you can spend 1 day of downtime and attempt a Crafting check with a high DC for your level. On a success, you rebuild your companion. You can have only one construct companion at a time, and you can have either a construct companion or an animal companion, but not both." };
            yield return new TextBlock { Id = Guid.Parse("389515a5-d062-4f17-885c-36115bcc539f"), Type = TextBlockType.Heading, Text = $"**Riding Construct Companions***" };
            yield return new TextBlock { Id = Guid.Parse("fd7f7d2f-a18b-4325-9e77-a91fbd1c6de3"), Type = TextBlockType.Text, Text = $"You or an ally can ride your construct companion as long as your construct companion is at least one size larger than the rider." };
            yield return new TextBlock { Id = Guid.Parse("e845e7a4-461e-41ca-8632-1f0d0daecc7a"), Type = TextBlockType.Heading, Text = $"**Prototype Construct Companions***" };
            yield return new TextBlock { Id = Guid.Parse("28c2dfc3-81ce-4640-a6a5-506a9b466ca9"), Type = TextBlockType.Text, Text = $"The following are the base statistics for a prototype construct companion, the first construct companion most characters get. A companion has the same level you do. As you gain levels, you might make further adjustments as your companion grows more powerful. Construct companions calculate their modifiers and DCs just as you do, with one difference: the only item bonuses they can benefit from are to Speed." };
            yield return new TextBlock { Id = Guid.Parse("8355088a-4696-491c-a831-14cf4e23142d"), Type = TextBlockType.Heading, Text = $"*Construct Trait**" };
            yield return new TextBlock { Id = Guid.Parse("ec9dfceb-fd51-41fe-9c8a-79beb3e40c2a"), Type = TextBlockType.Text, Text = $"A construct companion has the {ToMarkdownLink<Models.Entities.Trait>("construct", Traits.Instances.Construct.ID)} trait. It's not a living creature, nor is it undead." };
            yield return new TextBlock { Id = Guid.Parse("da238f8f-865f-4672-a99a-050effd4c1d2"), Type = TextBlockType.Heading, Text = $"*Proficiencies**" };
            yield return new TextBlock { Id = Guid.Parse("557f5808-9f7b-443b-9a4d-ebf75ba0030b"), Type = TextBlockType.Text, Text = $"Your construct companion is trained in its unarmed attacks, unarmored defense, all saving throws, Perception, Acrobatics, and Athletics. Construct companions can't use abilities that require greater Intelligence, such as Coerce or Decipher Writing, even if trained in the appropriate skill, unless they have an ability that allows it." };
            yield return new TextBlock { Id = Guid.Parse("122f5589-539d-4963-a64f-449ed37235fd"), Type = TextBlockType.Heading, Text = $"*Size**" };
            yield return new TextBlock { Id = Guid.Parse("6804ff35-d7c7-4068-9cf9-c95d0f0ad218"), Type = TextBlockType.Text, Text = $"Your construct companion is either Small or Medium, chosen by you when you first gain the companion." };
            yield return new TextBlock { Id = Guid.Parse("45769eb1-9715-4d63-a0cc-d5acead16841"), Type = TextBlockType.Heading, Text = $"*Strikes**" };
            yield return new TextBlock { Id = Guid.Parse("b20a6f60-0c5a-4485-be51-12308d7888d0"), Type = TextBlockType.Text, Text = $"Your construct companion has two kinds of melee unarmed attacks. Its first unarmed attack deals 1d8 bludgeoning damage. Depending on the shape of your construct this could be a fist, tendril, or other similar unarmed attack. Its other unarmed attack deals 1d6 slashing or piercing damage (choose when you first gain the companion) and has the agile and finesse traits. Depending on the shape of your construct, this could be a spine or spike, jaws or fangs, a retractable blade, or other similar unarmed attack." };
            yield return new TextBlock { Id = Guid.Parse("7a3792fe-0663-4ae6-9226-b5c219b83619"), Type = TextBlockType.Heading, Text = $"*Ability Modifiers**" };
            yield return new TextBlock { Id = Guid.Parse("da3289db-9de2-43a8-aa2f-585f0cf59988"), Type = TextBlockType.Text, Text = $"A construct companion begins with base ability modifiers of Str +3, Dex +3, Con +2, Int –4, Wis +1, Cha +0." };
            yield return new TextBlock { Id = Guid.Parse("f0cfb889-bb55-4c43-9278-9827c1a8dddc"), Type = TextBlockType.Heading, Text = $"*Hit Points**" };
            yield return new TextBlock { Id = Guid.Parse("78c58a76-034c-4436-bc06-5da26fe711af"), Type = TextBlockType.Text, Text = $"Your construct companion has 10 Hit Points, plus a number of Hit Points equal to 6 plus its Constitution modifier for each level you have." };
            yield return new TextBlock { Id = Guid.Parse("4b6dc21a-a581-4e72-bffc-b8ab49c5e95c"), Type = TextBlockType.Text, Text = $"While constructs are usually immediately destroyed at 0 Hit Points, your construct companion is a little harder to destroy than other constructs are. When your construct reaches 0 Hit Points, it becomes broken and begins sparking and might be destroyed if you don't Repair it. This works the same as the normal dying rules and determines if your construct is destroyed, with the following two changes. First, most effects that end the dying condition don't work to save a construct companion, but a construct can be stabilized using the Administer First Aid action, using the Crafting skill instead of Medicine. Second, instead of gaining and tracking the wounded condition, if your construct becomes broken in this way more than twice within a 10-minute period, it's destroyed, and you'll need to reconstruct it by spending a day of downtime." };
            yield return new TextBlock { Id = Guid.Parse("9951c34a-a36f-41bd-bec9-7ed615cb53d5"), Type = TextBlockType.Heading, Text = $"*Immunities**" };
            yield return new TextBlock { Id = Guid.Parse("fd58f06f-2702-4770-832f-b6455cdcc5e9"), Type = TextBlockType.Text, Text = $"Because it's a construct, your construct companion is immune to bleed, death effects, disease, doomed, drained, fatigued, healing, necromancy, nonlethal attacks, paralyzed, poison, sickened, and unconscious. Because the construct isn't a living creature, effects that heal living creatures can't help it recover Hit Points. Restoring Hit Points to it requires using the Repair action or other means that can restore Hit Points to objects and nonliving creatures." };
            yield return new TextBlock { Id = Guid.Parse("c3fde546-4411-4bc9-aa96-c36b4c86b54b"), Type = TextBlockType.Heading, Text = $"*Senses**" };
            yield return new TextBlock { Id = Guid.Parse("78ee4f7a-c7e3-44ad-8b16-0c1b6573446e"), Type = TextBlockType.Text, Text = $"Your construct companion has precise vision, imprecise hearing, and vague touch senses, but no sense of smell or taste." };
            yield return new TextBlock { Id = Guid.Parse("9f0ef0d3-4fd6-4446-aaa3-75683fa81fa5"), Type = TextBlockType.Heading, Text = $"*Speed**" };
            yield return new TextBlock { Id = Guid.Parse("e627563b-414b-45a7-b11c-9f2b49e19619"), Type = TextBlockType.Text, Text = $"Your construct companion has a Speed of 25 feet." };
            yield return new TextBlock { Id = Guid.Parse("e0c22af0-f3dc-4ebc-8a83-49166f55c7ad"), Type = TextBlockType.Heading, Text = $"**Advanced Construct Companions***" };
            yield return new TextBlock { Id = Guid.Parse("343f9716-ad1b-4914-a43f-e0f0495aed08"), Type = TextBlockType.Text, Text = $"To advance a prototype construct companion to an advanced construct companion (usually a result of one of your class feat choices), make the following adjustments." };
            yield return new TextBlock { Id = Guid.Parse("094537eb-dbbc-4fdf-9031-f22a619dbf5b"), Type = TextBlockType.Enumeration, Text = $" : Increase its Strength, Dexterity, Constitution, and Wisdom modifiers by 1." };
            yield return new TextBlock { Id = Guid.Parse("1e801c80-99f0-4d47-adb5-5397aa834778"), Type = TextBlockType.Enumeration, Text = $" : Increase its unarmed attack damage from one die to two dice (for instance, 1d8 to 2d8)." };
            yield return new TextBlock { Id = Guid.Parse("e4bb6851-a6b5-489a-a239-ab4d5a79c257"), Type = TextBlockType.Enumeration, Text = $" : Increase its proficiency rank for Perception and all saving throws to expert." };
            yield return new TextBlock { Id = Guid.Parse("a249c72b-695a-465e-8bfc-2feda8477e28"), Type = TextBlockType.Enumeration, Text = $" : Increase its proficiency ranks in Intimidation, Stealth, and Survival to trained. If the construct is your innovation and it was already trained in those skills from a modification, increase its proficiency rank in those skills to expert." };
            yield return new TextBlock { Id = Guid.Parse("e7889f40-87b1-496f-8da6-46e0609a0463"), Type = TextBlockType.Enumeration, Text = $" : You can change your companion's Size, if you want, to either Small, Medium, or Large." };
            yield return new TextBlock { Id = Guid.Parse("5c445d76-ca3f-4b78-a2c8-6b764870d17e"), Type = TextBlockType.Heading, Text = $"**Incredible Construct Companions***" };
            yield return new TextBlock { Id = Guid.Parse("94d0d73c-293a-4350-86c8-a064e999f5c1"), Type = TextBlockType.Text, Text = $"To improve an advanced construct companion to an incredible construct companion, make the following adjustments." };
            yield return new TextBlock { Id = Guid.Parse("be9e0a96-e09e-4708-96eb-5ebd2d3c876b"), Type = TextBlockType.Enumeration, Text = $" : Increase its Strength, Dexterity, Constitution and Wisdom modifiers by 2." };
            yield return new TextBlock { Id = Guid.Parse("2cf9ffd9-b4c2-460a-bcc9-35bd0092a044"), Type = TextBlockType.Enumeration, Text = $" : It deals 2 additional damage with its unarmed attacks. Its attacks become magical, allowing it to bypass resistances to non-magical attacks." };
            yield return new TextBlock { Id = Guid.Parse("c73f40e0-ff6d-472c-9b90-e189dc887451"), Type = TextBlockType.Enumeration, Text = $" : Increase its proficiency ranks in Athletics and Acrobatics to expert." };
            yield return new TextBlock { Id = Guid.Parse("8c62b4f7-2e4d-43c5-92a7-ac0d0b5a17a8"), Type = TextBlockType.Heading, Text = $"**Paragon Construct Companions***" };
            yield return new TextBlock { Id = Guid.Parse("86003c7f-f05d-4b62-a2e5-145018c1bbb5"), Type = TextBlockType.Text, Text = $"To improve an incredible construct companion to a paragon construct companion, make the following adjustments." };
            yield return new TextBlock { Id = Guid.Parse("d55255e4-86f5-4e9e-a231-f9539d2979e0"), Type = TextBlockType.Enumeration, Text = $" : Increase its Strength, Dexterity, Constitution, and Wisdom modifiers by 1." };
            yield return new TextBlock { Id = Guid.Parse("022f183d-c16f-4b94-b630-42c16f782a5c"), Type = TextBlockType.Enumeration, Text = $" : Increase its proficiency rank for unarmed attacks and unarmored defense to expert." };
            yield return new TextBlock { Id = Guid.Parse("a4964398-3b40-4f4e-a359-04af49a10d2c"), Type = TextBlockType.Enumeration, Text = $" : Increase its proficiency ranks for Athletics, Acrobatics, saving throws, and Perception to master." };
            yield return new TextBlock { Id = Guid.Parse("f121d7ca-1016-4926-9082-4fbc321e460a"), Type = TextBlockType.Enumeration, Text = $" : Increase its unarmed attack damage from two dice to three dice, and its additional damage with unarmed attacks from 2 to 4." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21f3e3de-fce8-4750-b1c0-074004bf0543"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 32
            };
        }
    }
}
