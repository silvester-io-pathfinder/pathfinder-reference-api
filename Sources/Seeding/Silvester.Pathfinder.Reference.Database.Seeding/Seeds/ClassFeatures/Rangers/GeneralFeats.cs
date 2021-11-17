using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class GeneralFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("1e417289-05cd-4251-a0c4-dba1e40c6878");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "General Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a5e3657e-0756-4e23-8387-ac216a8be9d8"), Type = TextBlockType.Text, Text = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyGeneralFeat(Guid.Parse("807be978-92a8-4872-85f4-6255fa19742a"), Guid.Parse("c5f80014-0acd-4576-8029-892b23cd1fe4"), requiredLevel: 3);
            builder.GainAnyGeneralFeat(Guid.Parse("85f06a9a-6290-4a14-a73a-5300aee86676"), Guid.Parse("c956b840-36f6-4e4b-bf3e-80e42ba387db"), requiredLevel: 7);
            builder.GainAnyGeneralFeat(Guid.Parse("6bd00d0b-c8c6-4381-bab8-17ca9377364e"), Guid.Parse("51fb2129-fe7b-4d78-ab6f-72144e6ad903"), requiredLevel: 11);
            builder.GainAnyGeneralFeat(Guid.Parse("e7f2c789-adfe-47b6-b94d-fda14d78c1b6"), Guid.Parse("0cde8fa7-e30d-4d1b-8c73-ac75d53e1f8e"), requiredLevel: 15);
            builder.GainAnyGeneralFeat(Guid.Parse("53e33d10-2b9f-4ed6-bb9f-29bade4c86a4"), Guid.Parse("efc414cf-17c3-417a-a829-7018bf7b1785"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba46d67c-2bb2-4ed8-ac20-cacc1d01c89b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 168
            };
        }
    }
}
