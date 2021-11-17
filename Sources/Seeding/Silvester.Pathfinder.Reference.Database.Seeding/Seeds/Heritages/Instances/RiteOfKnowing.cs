using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class RiteOfKnowing : Template
    {
        public static readonly Guid ID = Guid.Parse("e9bbc9f6-14de-4720-b2bb-c79eb239c279");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Rite of Knowing"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("87034d13-ae29-465f-9f83-efaa0dcee221"), Type = TextBlockType.Text, Text = "You enhanced your exoskeleton with a connection to Axis, allowing you to tap into the infinite knowledge of the plane. You gain the Call to Axis action." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("aa3ea2f3-89fd-43ff-b41c-075b5e4757f8"), Feats.Instances.CallToAxis.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb2e68f8-d6b8-4ab4-9877-f581c73b7bf0"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 107
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Conrasu.ID;
        }
    }
}
