using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashDarkPersona : Template
    {
        public static readonly Guid ID = Guid.Parse("c178d9c9-7fa4-4ab8-b01c-36f62b5d1dec");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Dark Persona",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d9b4fae-c9d5-4acf-b379-6d0b8fb0e29a"), Type = TextBlockType.Text, Text = "Your rage and pain coalesce into your dark persona, the portion of your psyche dedicated to cruel and immediate retribution." };
            yield return new TextBlock { Id = Guid.Parse("15b30c64-f8f1-4129-b7a1-66618da19390"), Type = TextBlockType.Text, Text = "~ Benefit: Your focus narrows on the enemy who damaged you; if multiple enemies have damaged you on at least two turns, select one. Whenever you deal damage to the selected enemy with a spell that doesn’t have a duration, you gain a status bonus to the damage equal to the spell level, or double the spell level if you cast the spell from your spell slots. Additionally, you gain temporary Hit Points equal to the spell’s level that last until the beginning of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("14d6ffde-0fe3-49da-a5fb-434401abedaf"), Type = TextBlockType.Text, Text = "~ Drawback: Your dark persona is focused on destroying your hated foe and pays little attention to other foes or your allies. While your dark persona is unleashed, you can’t cast beneficial spells on your allies, and you take a –1 penalty to your checks and DCs against targets other than your chosen foe." };
            yield return new TextBlock { Id = Guid.Parse("67e0ba89-ec11-4854-a741-7dc81b2316c2"), Type = TextBlockType.Text, Text = "If you defeat the selected enemy, your dark persona ends even if the psyche’s duration hasn’t passed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23ed3541-a707-4bc4-94e3-5411ac92ea51"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
