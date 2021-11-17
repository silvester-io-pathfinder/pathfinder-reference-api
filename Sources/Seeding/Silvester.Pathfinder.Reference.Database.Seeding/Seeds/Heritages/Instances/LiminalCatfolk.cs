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
    public class LiminalCatfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("8be78dab-ee01-4d74-8648-07d5de2907ac");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Liminal Catfolk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3b678956-baf0-4aa6-ab4a-a9e788c15324"), Type = TextBlockType.Text, Text = "You've inherited a closeness to the far corners of the world, where the boundaries between dimensions grow thin. You can cast detect magic as an occult innate cantrip heightened to half your level, rounded up. You also gain a +1 circumstance bonus to Occultism checks to Recall Knowledge about creatures that originated outside of the Material Plane." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInnateSpell(Guid.Parse("d2441487-02df-4b82-8409-7d0266c172d0"), Spells.Instances.DetectMagic.ID, MagicTraditions.Instances.Occult.ID);
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("deb0169f-1db4-4c55-a074-c6b3f109f9eb"), Skills.Instances.Occultism.ID, SkillActions.Instances.RecallKnowledge.ID, bonus: 1, addendum: "Only applies to creatures that originated outside of the Material Plane.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("efce3db1-4d29-4511-bc02-415076b8ee7d"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 17
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
        }
    }
}
