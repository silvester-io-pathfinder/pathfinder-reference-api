using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiabolicCertitude : Template
    {
        public static readonly Guid ID = Guid.Parse("6fffbdbc-39ef-4f13-a6a0-4b2dd260124b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diabolic Certitude",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins and you can observe a devil.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ea6aeefc-361d-4565-89f7-2c4e7707beb3"), Type = TextBlockType.Text, Text = "Your Hellknight training drilled details of Hell’s denizens deep into your mind. Make an attempt to (action: Recall Knowledge) about a devil you’re observing. If you roll a critical failure on this check, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fd99fcc1-f72f-49f5-9070-a4b7758b5786"), Feats.Instances.HellknightArmigerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a5fa2a13-80bc-4081-99bc-2bedfc48ae4c"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
