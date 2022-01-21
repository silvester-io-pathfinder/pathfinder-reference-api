using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicFrenzy : Template
    {
        public static readonly Guid ID = Guid.Parse("18a4d03b-a74c-4118-ac2f-b45a158bb513");

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
            yield return new TextBlock { Id = Guid.Parse("f2738661-ac58-440c-a945-c7e79b6f80d5"), Type = TextBlockType.Text, Text = $"Your eidolon makes one {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with their primary unarmed attack and two {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} with their secondary unarmed attack (in any order). If any of these attacks critically hits an enemy, your eidolon instantly recovers the use of their {ToMarkdownLink<Models.Entities.Feat>("Breath Weapon", Feats.Instances.BreathWeapon.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ed66843-c72f-43b1-b623-dd4a240ee414"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
