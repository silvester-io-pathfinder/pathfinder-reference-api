using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RapidAffixture : Template
    {
        public static readonly Guid ID = Guid.Parse("f339c53f-73d9-408b-8381-03bc149d3d26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rapid Affixture",
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
            yield return new TextBlock { Id = Guid.Parse("487d9603-b2ad-4106-a4cb-ab6d649c7a23"), Type = TextBlockType.Text, Text = "You take only 1 minute to (action: Affix a Talisman). If you’re legendary in Crafting, you can (action: Affix a Talisman) as a 3-action activity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d5b32836-8253-46a8-93a4-d35155edf923"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62f7e918-126e-4ac0-873b-97c92a06d75e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
