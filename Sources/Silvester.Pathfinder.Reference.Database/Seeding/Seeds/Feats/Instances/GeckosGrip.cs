using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GeckosGrip : Template
    {
        public static readonly Guid ID = Guid.Parse("95c2392f-e94e-4230-a4c1-f5df62c16499");

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
            yield return new TextBlock { Id = Guid.Parse("948db243-3d64-4e81-8755-f9da3ea089d3"), Type = TextBlockType.Text, Text = "You stick to walls with a preternatural grip. You gain a climb Speed of 15 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("fed9c2ce-0151-4f12-bc80-c1aba1c0d11f"), Heritages.Instances.CliffscaleLizardfolk.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("28ae668c-9a53-4d9e-bd81-c47a60b5c589"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
