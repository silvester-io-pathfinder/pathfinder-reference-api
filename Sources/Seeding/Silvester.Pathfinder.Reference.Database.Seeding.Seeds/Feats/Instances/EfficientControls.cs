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
    public class EfficientControls : Template
    {
        public static readonly Guid ID = Guid.Parse("31136e2f-d219-4078-b183-4287bf51b459");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Efficient Controls",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("da663e52-5ffa-4715-8f13-61aae460d82f"), Type = TextBlockType.Text, Text = $"By reducing redundant systems and streamlining essential functions, you have made it easier for the vehicle to operate with fewer crew. Reduce the number of crew required to operate your signature vehicle by 25%. For example, you would reduce a sailing ship from needing 1 pilot and 8 crew to 1 pilot and 6 crew. This adjustment only affects the number of crew needed to operate the vehicle; it doesn't reduce the vehicle's need for a pilot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("863b32f2-3698-420c-baa5-a4bfd522f2b5"), Feats.Instances.VehicleMechanicDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("2956094e-6eeb-4933-8167-caf362e48f23"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("857a3e8c-31e0-4c28-b221-b7e283d3fa4d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
