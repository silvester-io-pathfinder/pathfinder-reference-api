using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicFrenzy : Template
    {
        public static readonly Guid ID = Guid.Parse("eb42bc39-a899-4334-bd19-eb492c3bebed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Frenzy",
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
            yield return new TextBlock { Id = Guid.Parse("178bc01e-e419-483b-8261-b23164dde97b"), Type = TextBlockType.Text, Text = "Your eidolon makes one (action: Strike) with their primary unarmed attack and two (action: Strikes | Strike) with their secondary unarmed attack (in any order). If any of these attacks critically hits an enemy, your eidolon instantly recovers the use of their (action: Breath Weapon)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afd0fa38-b450-45e2-8f11-af854f277aa1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
