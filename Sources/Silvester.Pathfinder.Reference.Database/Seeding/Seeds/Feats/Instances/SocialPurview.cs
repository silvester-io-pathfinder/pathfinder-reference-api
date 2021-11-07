using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SocialPurview : Template
    {
        public static readonly Guid ID = Guid.Parse("61159fe1-ad26-4174-ab34-28c2b58a9b21");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Social Purview",
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
            yield return new TextBlock { Id = Guid.Parse("a88b6a7b-514c-4b52-be5d-6d41d9da65fe"), Type = TextBlockType.Text, Text = "You have built a reputation for yourself in your social identity. Choose one archetype that you meet the prerequisites for. You gain that archetype’s dedication feat and can select feats from that archetype, even if you haven’t yet gained enough feats in the vigilante archetype to take another dedication feat. These feats become part of your social identity and gain the (trait: social) trait – for instance, a fighter vigilante could take the (feat: Wizard Dedication) feat and have a wizard social identity. Using these feats in your social identity doesn’t risk exposing your vigilante identity, but using them in your vigilante identity could put you at risk for exposure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b614e3a5-3a2b-43eb-925e-9d868cce1d33"), Feats.Instances.VigilanteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2251b57c-fc70-475a-bd63-126ee2836b07"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
