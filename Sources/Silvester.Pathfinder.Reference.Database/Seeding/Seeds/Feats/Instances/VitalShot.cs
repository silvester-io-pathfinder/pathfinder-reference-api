using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VitalShot : Template
    {
        public static readonly Guid ID = Guid.Parse("2e205fc0-b922-45aa-8bc0-5f4ffeaef23b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vital Shot",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c4fab6b3-97df-446e-8ba2-c230d8492f09"), Type = TextBlockType.Text, Text = "Your careful shot against an unsuspecting opponent pierces a vital artery or organ. Make a ranged (action: Strike). If the target is flat-footed, the (action: Strike) deals an extra die of weapon damage, and the foe takes persistent bleed damage equal to the amount of precision damage from your (feat: One Shot, One Kill)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3af1bbd-64ad-4833-8cfa-c7bcfc58bffb"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
