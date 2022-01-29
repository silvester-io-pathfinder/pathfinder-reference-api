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
    public class TwoWeaponFlurry : Template
    {
        public static readonly Guid ID = Guid.Parse("e0c3b983-07b3-48b4-a766-35844ff998df");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Two-Weapon Flurry",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("50040571-465e-41da-8992-98d306018e76"), Type = TextBlockType.Text, Text = $"You lash out with both your weapons in a sudden frenzy. {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} twice, once with each weapon." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("349a922e-8e2c-450f-b2a1-8b3c0dad46e9"), Feats.Instances.DualWeaponWarriorDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fighter.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Press.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e55d22ee-5ecc-46f1-bd01-14186e11904b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
