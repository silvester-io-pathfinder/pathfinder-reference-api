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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You've learned to be aware of not just obvious physical dangers, but also noticeable magical threats. You can cast the detect magic cantrip as an arcane innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. In addition, your awareness allows you to notice magical traps easier than others. Your proficiency rank in Perception is considered one step better when attempting to detect magical traps. (Trained is considered expert, expert is considered master, and master is considered legendary)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInnateSpell(Guid.Parse(""), Spells.Instances.DetectMagic.ID, MagicTraditions.Instances.Arcane.ID);
            builder.Manual(Guid.Parse(""), "Your proficiency rank in Perception is considered one step better when attempting to detect magical traps. (Trained is considered expert, expert is considered master, and master is considered legendary).");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
