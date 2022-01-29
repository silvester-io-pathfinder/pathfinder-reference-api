using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SoulArsenal : Template
    {
        public static readonly Guid ID = Guid.Parse("8dc9f977-4708-43f1-a789-d692ad8c5349");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soul Arsenal",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat a second time at 12th level or higher, choosing the final item type.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("afbf4d42-195d-4af0-8686-452eb5069166"), Type = TextBlockType.Text, Text = $"Choose an additional soulforged armament of a different type than the type you already chose, and choose one essence power for it. Upgrade and change armaments individually." };
            yield return new TextBlock { Id = Guid.Parse("c8693945-0cc3-4b1c-8418-cd83df4c9e49"), Type = TextBlockType.Text, Text = $"When you Manifest Soulforged Armament, you can summon any number of your armaments (you must meet the Requirements for each), and when you {ToMarkdownLink<Models.Entities.Action>("Dismiss", Actions.Instances.Dismiss.ID)} the effect, you can choose to {ToMarkdownLink<Models.Entities.Action>("Dismiss", Actions.Instances.Dismiss.ID)} some and not others. You can choose to manifest the essence form of any number of your armaments when you take the action. Each armament can manifest its essence form only once per day." };
            yield return new TextBlock { Id = Guid.Parse("f6c26654-f21e-4cfb-9ab3-9bfd9090112d"), Type = TextBlockType.Text, Text = $"When you gain soulforged corruption, choose one armament's corruption flaw to affect you for stage 1. At stage 2, you take the flaws of all your soulforged armaments. While you have the curse, each armament gets a separate flat check to manifest its essence form, and failing prevents you from manifesting only that armament's essence form." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("120f9314-a751-4a0a-a1c7-6851af0b3055"), Feats.Instances.ManifestSoulforgedArmament.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9781d47b-1667-4e53-ba07-b6d52f3ced90"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
