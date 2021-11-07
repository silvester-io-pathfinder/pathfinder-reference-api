using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScholarlyDefense : Template
    {
        public static readonly Guid ID = Guid.Parse("2df22052-005f-4871-b2d7-43cb3923a513");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scholarly Defense",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8e168928-bf42-4773-b6ab-fc535c5f4dd3"), Type = TextBlockType.Text, Text = "Your knowledge of strange creatures and their bizarre anatomy allows you to anticipate their physical attacks and reduce the damage you take from them. You gain resistance to physical damage from melee attacks made by aberrations and oozes. This resistance is equal to one-third your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("92deae68-5e4f-4035-8581-f3bd84724882"), Feats.Instances.EldritchResearcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d52e45c2-233a-40d4-8d50-77d340a0ab85"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
