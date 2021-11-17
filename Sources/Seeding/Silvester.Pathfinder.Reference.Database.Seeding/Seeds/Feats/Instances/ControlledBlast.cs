using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ControlledBlast : Template
    {
        public static readonly Guid ID = Guid.Parse("a9126cef-9cc4-43dc-8c7c-0f6da3ba102e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Controlled Blast",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd28e3c9-288b-45e7-b396-371a4cf49b1d"), Type = TextBlockType.Text, Text = "You maximize the effectiveness of your explosives by controlling every possible parameter of the blast meticulously. If you have the (feat: Directional Bombs) feats, you can use it with (feat: Set Explosives) or (feat: Demolition Charge), even though you didn’t throw the bombs. If you have the (feat: Calculated Splash) or (feat: Expanded Splash) feats, you can apply the additional splash damage to one of the bombs when you (feat: Set Explosives) or use (feat: Demolition Charge), and you can apply the increased splash area from (feat: Expanded Splash) to all the bombs." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("14c19b03-57c4-4617-94ef-0c0f6b7be52a"), Feats.Instances.DemolitionistDedication.ID);
            builder.AddOr(Guid.Parse("db136998-5233-4dd3-93a7-299a2d34ad61"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("6bccba2e-0411-44d2-91ec-107e4beff1ff"), Feats.Instances.CalculatedSplash.ID);
                or.HaveSpecificFeat(Guid.Parse("a57ffb72-266b-4c79-81ab-2bcc423632e1"), Feats.Instances.DirectionalBombs.ID);
                or.HaveSpecificFeat(Guid.Parse("95b04f89-9dd3-4b80-90ee-5a83f032f98c"), Feats.Instances.ExpandedSplash.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74b377e4-3bad-49e6-9fac-3eb388800ae0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
