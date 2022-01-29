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
    public class RescuersPress : Template
    {
        public static readonly Guid ID = Guid.Parse("96708fed-cfc6-4ea9-9063-e3e755fc5040");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rescuer's Press",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("edd0102c-efda-4bb6-804c-0622d0555c48"), Type = TextBlockType.Text, Text = $"Any shield you wield gains the {ToMarkdownLink<Models.Entities.Trait>("shove", Traits.Instances.Shove.ID)} trait. When you {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} using a shield and {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} as part of that action, you can move an additional 5 feet to either side of the creature you {ToMarkdownLink<Models.Entities.SkillAction>("Shoved", SkillActions.Instances.Shove.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("6e885b08-2459-4f45-ab3e-0a5ec91635e0"), Type = TextBlockType.Text, Text = $"In addition, if you are in the {ToMarkdownLink<Models.Entities.Feat>("Everstand Stance", Feats.Instances.EverstandStance.ID)} and successfully {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} a creature using a shield that you wield two-handed, you can increase the distance of your {ToMarkdownLink<Models.Entities.SkillAction>("Shove", SkillActions.Instances.Shove.ID)} to 10 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cfe22ea3-7d12-4bad-9a53-4ab42eb02a43"), Feats.Instances.LastwallSentryDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3427401-a0aa-4728-bb00-323cd130c845"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
