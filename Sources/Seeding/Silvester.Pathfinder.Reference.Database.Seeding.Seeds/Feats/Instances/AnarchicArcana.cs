using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnarchicArcana : Template
    {
        public static readonly Guid ID = Guid.Parse("8e95f93f-ca54-45aa-8bc3-82c9f40e0f5d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anarchic Arcana",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8a0a07b6-d6f8-443a-8163-97b3f01ace2b"), Type = TextBlockType.Text, Text = $"The magic in your blood is unpredictable. When you make your daily preparations, roll 1d12 twice and consult the following list." };
            yield return new TextBlock { Id = Guid.Parse("c77e2d81-d713-4752-a341-3db835e2bd09"), Type = TextBlockType.Enumeration, Text = $" 1: {ToMarkdownLink<Models.Entities.Spell>("acid arrow", Spells.Instances.AcidArrow.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("b85a9417-816d-47f9-87ef-0c9da45335bf"), Type = TextBlockType.Enumeration, Text = $" 2: {ToMarkdownLink<Models.Entities.Spell>("blur", Spells.Instances.Blur.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("d08b218b-df5d-46b0-b31f-113973a996c3"), Type = TextBlockType.Enumeration, Text = $" 3: {ToMarkdownLink<Models.Entities.Spell>("hideous laughter", Spells.Instances.HideousLaughter.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("242b3fda-b7a9-47aa-95a6-65418c0cdbe2"), Type = TextBlockType.Enumeration, Text = $" 4: {ToMarkdownLink<Models.Entities.Spell>("humanoid form", Spells.Instances.HumanoidForm.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("f5df2c99-d76a-4d9a-875d-c378da12e99c"), Type = TextBlockType.Enumeration, Text = $" 5: {ToMarkdownLink<Models.Entities.Spell>("illusory object", Spells.Instances.IllusoryObject.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("dd5c7a04-56f6-43c1-aa63-5ec2e6047b8d"), Type = TextBlockType.Enumeration, Text = $" 6: {ToMarkdownLink<Models.Entities.Spell>("mirror image", Spells.Instances.MirrorImage.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("cae8fb77-8659-4e6b-9b63-a672400b16bb"), Type = TextBlockType.Enumeration, Text = $" 7: {ToMarkdownLink<Models.Entities.Spell>("resist energy", Spells.Instances.ResistEnergy.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("013c144e-c3f8-4e4d-9e2d-becdaf4c7638"), Type = TextBlockType.Enumeration, Text = $" 8: {ToMarkdownLink<Models.Entities.Spell>("see invisibility", Spells.Instances.SeeInvisibility.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("e996407b-6981-4b14-8aa8-daee6179a8ea"), Type = TextBlockType.Enumeration, Text = $" 9: {ToMarkdownLink<Models.Entities.Spell>("shatter", Spells.Instances.Shatter.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("e2acc8ab-d861-4eec-9225-9c616be9313f"), Type = TextBlockType.Enumeration, Text = $" 10: {ToMarkdownLink<Models.Entities.Spell>("sound burst", Spells.Instances.SoundBurst.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("477c0709-1f4a-4e81-ad96-12998c79ffa0"), Type = TextBlockType.Enumeration, Text = $" 11: {ToMarkdownLink<Models.Entities.Spell>("spider climb", Spells.Instances.SpiderClimb.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("1d03db97-e465-4bbc-a8aa-11a52cfe1b68"), Type = TextBlockType.Enumeration, Text = $" 12: {ToMarkdownLink<Models.Entities.Spell>("telekinetic maneuver", Spells.Instances.TelekineticManeuver.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("0b9068e8-e78b-4be0-abdd-bb908f3fde9a"), Type = TextBlockType.Text, Text = $"You can cast each of those two spells once during the following day (or one spell twice if you rolled doubles) as 2nd-level divine innate spells." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a42d4a1-6755-45fc-ac66-42fbfc85a26f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
