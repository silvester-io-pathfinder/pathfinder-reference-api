using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashDarkPersona : Template
    {
        public static readonly Guid ID = Guid.Parse("afbc5543-e814-43a4-a81b-468a9c3619dd");

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
            yield return new TextBlock { Id = Guid.Parse("224d4c07-8938-407d-8d89-086640f34a88"), Type = TextBlockType.Text, Text = "Your rage and pain coalesce into your dark persona, the portion of your psyche dedicated to cruel and immediate retribution." };
            yield return new TextBlock { Id = Guid.Parse("75a64dc8-37af-441a-a836-d8575fb84ee3"), Type = TextBlockType.Text, Text = "~ Benefit: Your focus narrows on the enemy who damaged you; if multiple enemies have damaged you on at least two turns, select one. Whenever you deal damage to the selected enemy with a spell that doesn’t have a duration, you gain a status bonus to the damage equal to the spell level, or double the spell level if you cast the spell from your spell slots. Additionally, you gain temporary Hit Points equal to the spell’s level that last until the beginning of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("7d0f58b7-d3e9-43f3-8956-a7a48acbed45"), Type = TextBlockType.Text, Text = "~ Drawback: Your dark persona is focused on destroying your hated foe and pays little attention to other foes or your allies. While your dark persona is unleashed, you can’t cast beneficial spells on your allies, and you take a –1 penalty to your checks and DCs against targets other than your chosen foe." };
            yield return new TextBlock { Id = Guid.Parse("ad2de534-9981-48d2-a430-a0cede1328a6"), Type = TextBlockType.Text, Text = "If you defeat the selected enemy, your dark persona ends even if the psyche’s duration hasn’t passed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a780ebba-0230-495c-8e1b-1366a1a721eb"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
