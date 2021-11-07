using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GeckosGrip : Template
    {
        public static readonly Guid ID = Guid.Parse("2ee4bc89-f2e4-4be1-ac7e-bf6cc39433de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gecko's Grip",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5eb93fde-9eea-4c05-b5b2-1bb88f35813e"), Type = TextBlockType.Text, Text = "You stick to walls with a preternatural grip. You gain a climb Speed of 15 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("c75e5749-3ad8-4890-a4c5-1d634e12ec73"), Heritages.Instances.CliffscaleLizardfolk.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0774e469-ee83-4bec-8bad-7fbab20bacdd"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
