using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class AncientBloodedDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("4023db86-7064-4ad0-936e-e1f5c95e921b");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Ancient-Blooded Dwarf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9b0ae32c-3d52-491a-af08-89d6517318b6"), Type = TextBlockType.Text, Text = "Dwarven heroes of old could shrug off their enemies' magic, and some of that resistance manifests in you. You gain the Call on Ancient Blood reaction." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("31fc1a71-bc7b-43f1-9f5b-769e35dfd433"), Feats.Instances.CallOnAncientBlood.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af73858c-c385-432c-b39b-f873ca45155f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 35
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Dwarf.ID;
        }
    }
}
