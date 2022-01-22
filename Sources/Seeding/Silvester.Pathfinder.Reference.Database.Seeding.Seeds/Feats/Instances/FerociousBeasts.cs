using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FerociousBeasts : Template
    {
        public static readonly Guid ID = Guid.Parse("92de2e4f-88e0-4636-bc5a-a0c3814a6fd3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ferocious Beasts",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2c4e1ab1-f3b1-475b-87f5-950ed3a8b723"), Type = TextBlockType.Text, Text = $"Since ancient times, the mightiest orc beast tamers would draw out the true fighting spirit of their companion beasts by feeding the creatures a draft incorporating the orc's own blood. Animal companions or bonded animals you have gain the {ToMarkdownLink<Models.Entities.Feat>("Orc Ferocity", Feats.Instances.OrcFerocity.ID)} feat, and they gain a reaction they can use only for {ToMarkdownLink<Models.Entities.Feat>("Orc Ferocity", Feats.Instances.OrcFerocity.ID)}. If you have the {ToMarkdownLink<Models.Entities.Feat>("Undying Ferocity", Feats.Instances.UndyingFerocity.ID)} ancestry feat, all animal companions or bonded animals you have also gain the benefits of that feat when using the {ToMarkdownLink<Models.Entities.Feat>("Orc Ferocity", Feats.Instances.OrcFerocity.ID)} reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("57384ad2-c71f-41c1-91d5-d71c0ccac6b3"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("9fd21685-30e1-4b67-aa8b-581ee2eaa3d9"), Feats.Instances.BeastTrainer.ID);
                or.HaveSpecificFeat(Guid.Parse("85763b68-3ee8-4e96-99fd-adb3aec11931"), Feats.Instances.AnimalCompanion.ID);
            });
            builder.HaveSpecificFeat(Guid.Parse("b3bfaea3-df30-468a-bf29-92e4104aeed2"), Feats.Instances.OrcFerocity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0cdaac1a-abd7-43f6-b13b-fc1d2061dfa4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
