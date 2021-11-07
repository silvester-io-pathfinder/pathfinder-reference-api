using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OddityIdentification : Template
    {
        public static readonly Guid ID = Guid.Parse("4d05bf3a-b535-4339-85ea-81a2d2252f67");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Oddity Identification",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46180057-acc9-40f0-a516-5b985506fd32"), Type = TextBlockType.Text, Text = "You have a sense for spells that twist minds or reveal secrets. You gain a +2 circumstance bonus to Occultism checks to (Action: Identify Magic) with the (trait: mental), (trait: possession), (trait: prediction), or (trait: scrying) traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("cfedfbc1-2840-4abd-8316-ad96963faeff"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac2b34da-9498-4bc7-ab13-c4115a90a24a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
