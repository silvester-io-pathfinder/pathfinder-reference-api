using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationCamouflagePigmentation : Template
    {
        public static readonly Guid ID = Guid.Parse("ec06880e-d8df-4210-9c74-7e56526288b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification -  Camouflage Pigmentation",
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
            yield return new TextBlock { Id = Guid.Parse("859f1ea6-bde2-4cf3-9ed0-266a89597ef3"), Type = TextBlockType.Enumeration, Text = $"*Subterfuge Suit Only**" };
            yield return new TextBlock { Id = Guid.Parse("9d346758-d75e-4c56-acc1-d8080ef07f17"), Type = TextBlockType.Text, Text = $"You've modified your armor's exterior to let you blend into your surroundings with ease, as long as you stay still. While wearing your armor, you can {ToMarkdownLink<Models.Entities.SkillAction>("Hide", SkillActions.Instances.Hide.ID)} even without cover or concealment, as the pigmentation shifts to match your surroundings." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7889c5ba-dab7-475c-8a2a-fdd4457e3d18"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
