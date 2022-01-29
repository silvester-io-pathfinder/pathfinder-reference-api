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
    public class CourageousAdvance : Template
    {
        public static readonly Guid ID = Guid.Parse("f9977dc2-0617-44a6-abaf-f45caf37646d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Courageous Advance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c210ab7-167c-46d6-9957-bdbdbf64a86c"), Type = TextBlockType.Text, Text = $"With a rousing call, you exhort an ally to advance. If your next action is to cast the {ToMarkdownLink<Models.Entities.Spell>("inspire courage", Spells.Instances.InspireCourage.ID)} composition cantrip, one ally who gains a status bonus from the spell can immediately use a reaction to {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("f4cfdbcd-58b9-4e73-8827-41770665da7a"), Muses.Instances.Warrior.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9f9977fe-ce32-45d5-bbb3-05d7fb052274"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("89ae07b8-25bd-4528-a611-bce193121eb0"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("35afc072-1aac-43a1-a927-c98932594fbb"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("89c2f242-33c9-4900-ad63-97f218b7bbe7"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0bef088-b313-475f-b535-e9ee84fd2e3a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
