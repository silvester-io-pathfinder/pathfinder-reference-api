using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ManifestSoulforgedArmament : Template
    {
        public static readonly Guid ID = Guid.Parse("18fea604-9b7b-492e-95b3-2634afd947f8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Manifest Soulforged Armament",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("299ff331-06b4-459d-9af7-660de6a2ec16"), Type = TextBlockType.Text, Text = "You immediately wield or wear the soulforged armament bound to you. The soulforged armament remains manifested until you (action: Dismiss) this effect. Once per day when you use this ability, you can manifest the armament’s essence form. You gain the armament’s essence power until it’s (action: Dismissed|Dismiss). After 1 minute, the essence form armament is automatically (action: Dismissed|Dismiss)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f836a248-22bf-44aa-bdd2-40f23e0cf1ab"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
