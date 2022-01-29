using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SocialPurview : Template
    {
        public static readonly Guid ID = Guid.Parse("34e7d117-8849-4777-af8b-f34777817c83");

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
            yield return new TextBlock { Id = Guid.Parse("be1a2e9a-5e66-404f-8846-c9230a47a437"), Type = TextBlockType.Text, Text = $"You have built a reputation for yourself in your social identity. Choose one archetype that you meet the prerequisites for. You gain that archetype's dedication feat and can select feats from that archetype, even if you haven't yet gained enough feats in the vigilante archetype to take another dedication feat. These feats become part of your social identity and gain the {ToMarkdownLink<Models.Entities.Trait>("social", Traits.Instances.Social.ID)} trait – for instance, a fighter vigilante could take the {ToMarkdownLink<Models.Entities.Feat>("Wizard Dedication", Feats.Instances.WizardDedication.ID)} feat and have a wizard social identity. Using these feats in your social identity doesn't risk exposing your vigilante identity, but using them in your vigilante identity could put you at risk for exposure." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("624dbf14-d09f-44ff-bf78-39abdfead222"), Feats.Instances.VigilanteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dcf92203-51fc-4e79-a970-3799491880fe"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
