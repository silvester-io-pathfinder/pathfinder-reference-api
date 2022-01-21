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
    public class OathkeeperDwarf : Template
    {
        public static readonly Guid ID = Guid.Parse("88f9765e-66ed-4780-bb53-c23c27b4f8ad");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            {
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Oathkeeper Dwarf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a23fdb95-0e94-4ac8-ac20-d2ecde7457da"), Type = TextBlockType.Text, Text = "Growing up, you never tried to lie to get what you wanted, and even when necessary, lying makes you uncomfortable. The especially faithful might even have thought that you were blessed by the dwarven god of duty, Kols. You gain a +1 circumstance bonus to Perception checks to Sense Motive and to Perception DCs against attempts to Lie to you. Furthermore, you gain a +2 circumstance bonus to Diplomacy checks to convince others you speak the truth when you are telling the truth, and you take a –4 circumstance penalty to Lie and to your Deception DC against Sense Motive." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e09d172-1430-4550-a086-561591bf64d4"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 19
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Dwarf.ID;
        }
    }
}
