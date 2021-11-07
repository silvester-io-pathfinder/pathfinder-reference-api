using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PenetratingFire : Template
    {
        public static readonly Guid ID = Guid.Parse("9207c433-bd51-43ab-932f-fe3b7ffaba8c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Penetrating Fire",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b69fab2-ba25-41cc-9712-2ea2dfcb3236"), Type = TextBlockType.Text, Text = "You blast a bullet through one foe and into another. Choose two targets, one of which would give the other lesser cover against your ranged attacks. Make a single ranged (action: Strike) with the required weapon against both targets. This attack ignores any lesser cover the nearer target provides the other. Roll damage only once and apply it to each creature you hit. Penetrating Fire counts as two attacks for your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("171dd947-7d8a-44c2-b039-6fccd04a4085"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
