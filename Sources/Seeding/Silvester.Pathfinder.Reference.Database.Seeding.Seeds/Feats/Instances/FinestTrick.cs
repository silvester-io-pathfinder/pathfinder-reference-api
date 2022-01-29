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
    public class FinestTrick : Template
    {
        public static readonly Guid ID = Guid.Parse("dc6a58f0-c0f0-4359-8381-b33ef047c2c5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Finest Trick",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("73d1363f-05ab-44b4-a3c6-dab76c247737"), Type = TextBlockType.Text, Text = $"Many fiends—rakshasa rajas and demonic succubi most famously—can take on the forms of others. With practice, you can do the same. When you use {ToMarkdownLink<Models.Entities.Feat>("Devil in Plain Sight", Feats.Instances.DevilInPlainSight.ID)}, you can alter your appearance to match a generic member of your base ancestry, rather than one that's obviously you without your tieflings features. In addition, you can imitate a specific person's appearance (of any ancestry of the same size and kind as your base ancestry, typically a humanoid for most ancestries) if you consume a bit of their blood, a lock of their hair, or appropriate equivalents as part of the action. You still must know what the creature looks like, and you must be aware that the consumed portion comes from their body." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9331c706-febe-48de-85d8-cd34ddece774"), Feats.Instances.DevilInPlainSight.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Tiefling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c34dcb55-1707-445e-befd-344e810559be"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
