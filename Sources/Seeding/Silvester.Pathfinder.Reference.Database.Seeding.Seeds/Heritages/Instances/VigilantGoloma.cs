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
    public class VigilantGoloma : Template
    {
        public static readonly Guid ID = Guid.Parse("28a3316a-5ec7-4ca1-bae4-01a0ac39608e");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Vigilant Goloma"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("630246d9-d252-452d-be9e-30b0219ee658"), Type = TextBlockType.Text, Text = "You've learned to be aware of not just obvious physical dangers, but also noticeable magical threats. You can cast the detect magic cantrip as an arcane innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. In addition, your awareness allows you to notice magical traps easier than others. Your proficiency rank in Perception is considered one step better when attempting to detect magical traps. (Trained is considered expert, expert is considered master, and master is considered legendary)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInnateSpell(Guid.Parse("fb6978d0-7000-40c4-9696-e6a5923411a5"), Spells.Instances.DetectMagic.ID, MagicTraditions.Instances.Arcane.ID);
            builder.Manual(Guid.Parse("5f5445ad-337a-4e27-9498-3426773551d0"), "Your proficiency rank in Perception is considered one step better when attempting to detect magical traps. (Trained is considered expert, expert is considered master, and master is considered legendary).");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec37326a-a0c7-4a93-b452-71531e12d759"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 115
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Goloma.ID;
        }
    }
}
