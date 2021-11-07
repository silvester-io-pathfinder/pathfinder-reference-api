using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryGuide : Template
    {
        public static readonly Guid ID = Guid.Parse("daa36290-8d79-4212-bd7c-bd46d99f0883");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Guide",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22aed3e1-2227-4ccd-bc70-79a2f7f037ca"), Type = TextBlockType.Text, Text = "You know the wilderness so well that you can help your party travel through it with ease. When you are setting the path for your party through wilderness terrain, your party gains a +10-foot circumstance bonus to its Speed for the purpose of calculating the party&#39;s travel speed, your party&#39;s travel speed doesn&#39;t decrease in difficult terrain, and greater difficult terrain halves your party&#39;s travel speed instead of reducing it to a third. This doesn&#39;t increase your party&#39;s Speed during an encounter or allow your party to ignore difficult terrain during an encounter." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("0da93284-bc7e-47fa-8c7f-ddfcc7f93e6d"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd709e9f-1d53-4aaf-9f63-bc8bf1040893"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
