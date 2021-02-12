using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class LanguageSeeder : IEntitySeeder<Language>
    {
        public IEnumerable<Language> GetSeedEntities()
        {
            yield return new Language { Id = Guid.Parse("9200b27c-d210-4b47-bd77-43cfc86440d4"), TypeId = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Common",  };
            yield return new Language { Id = Guid.Parse("4bf191b9-77f7-47d0-89d7-e22555aaee7f"), TypeId = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Draconic" };
            yield return new Language { Id = Guid.Parse("59a55746-938a-459e-8ff3-ce201de0a452"), TypeId = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Dwarven"};
            yield return new Language { Id = Guid.Parse("4fc0e030-aa67-4913-b738-16b82ac46354"), TypeId = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Elven" };
            yield return new Language { Id = Guid.Parse("6582bcfc-19d6-4b4d-9c35-a25047433bb7"), TypeId = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Gnomish" };
            yield return new Language { Id = Guid.Parse("bbbe92c4-628e-4b49-a1fb-9845a0071980"), TypeId = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Goblin" };
            yield return new Language { Id = Guid.Parse("f05615ab-eba0-476d-8afd-1f628b90240b"), TypeId = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Halfling" };
            yield return new Language { Id = Guid.Parse("956c9a02-b3db-41d2-83f3-3c27fa43e510"), TypeId = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Jotun" };
            yield return new Language { Id = Guid.Parse("ba4a2924-27ab-49a1-b700-310b1cfb0c22"), TypeId = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Orcish" };
            yield return new Language { Id = Guid.Parse("be3b5aa6-e2eb-49b8-8273-a3eb516dcfc7"), TypeId = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Sylvan" };
            yield return new Language { Id = Guid.Parse("8700ff4d-89af-4d17-add5-381f3d595682"), TypeId = Guid.Parse("02fff45a-095f-4a5e-8c70-b5359692c1ac"), Name = "Undercommon" };

            yield return new Language { Id = Guid.Parse("7fba9655-f430-4ef1-acd7-996f398f4e60"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Abyssal" };
            yield return new Language { Id = Guid.Parse("6085b848-9283-494b-bf9d-999917f5d9d9"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Aklo" };
            yield return new Language { Id = Guid.Parse("fe8f7dca-685b-4595-8d0c-ee72e0239d58"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Aquan" };
            yield return new Language { Id = Guid.Parse("e3f3ba6c-0589-4c16-b625-093a1fa1edce"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Auran" };
            yield return new Language { Id = Guid.Parse("a2a126c5-0922-4e2c-929d-98cc10603aab"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Celestial" };
            yield return new Language { Id = Guid.Parse("6de09882-17f3-43f2-9c8d-81d78f75d988"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Gnoll" };
            yield return new Language { Id = Guid.Parse("f4c44558-f01d-4b2e-a98d-5ed75f5a5c87"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Ignan" };
            yield return new Language { Id = Guid.Parse("efaeb70a-9ba1-4026-a1cb-51272efba480"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Infernal" };
            yield return new Language { Id = Guid.Parse("3b5d9eb0-04e7-48a0-a611-32475680a811"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Necril" };
            yield return new Language { Id = Guid.Parse("1b30c0fb-885d-4b6f-a03c-2dd4c1639aae"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Shadowtongue" };
            yield return new Language { Id = Guid.Parse("096204ff-a686-4f09-95f9-9353401cb37a"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Terran" };
            yield return new Language { Id = Guid.Parse("b968b2e8-1dc2-4c33-b108-5c58c36d85ed"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Amurrun" };
            yield return new Language { Id = Guid.Parse("6a5332d4-f0b7-4e9b-8016-ccb5d03e9d0f"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Ysoki" };
            yield return new Language { Id = Guid.Parse("7c3e1ffc-a478-4009-986c-bf45770f5f10"), TypeId = Guid.Parse("ddd66834-fd35-4361-b798-c389e81b12a0"), Name = "Tengu" };

            yield return new Language { Id = Guid.Parse("c86cab6c-8b52-43bd-b98c-9eaf7f63d5df"), TypeId = Guid.Parse("9e4b5cea-7c60-4396-aa80-307379d155ab"), Name = "Druidic" };

            yield return new Language { Id = Guid.Parse("96b1db15-ad82-4a43-a5ad-a147d3611b4e"), TypeId = Guid.Parse("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0"), Name = "Hallit" };
            yield return new Language { Id = Guid.Parse("5bc03f6e-2b88-40f0-abde-fb539995f28b"), TypeId = Guid.Parse("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0"), Name = "Kelish" };
            yield return new Language { Id = Guid.Parse("981794a7-f756-4894-b903-2ed948b580be"), TypeId = Guid.Parse("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0"), Name = "Mwangi" };
            yield return new Language { Id = Guid.Parse("00ff0a21-2e5d-4b6b-b6ba-ddeaf331c464"), TypeId = Guid.Parse("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0"), Name = "Osiriani" };
            yield return new Language { Id = Guid.Parse("9074da30-a817-4a7d-a260-7fc10b02513a"), TypeId = Guid.Parse("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0"), Name = "Shoanti" };
            yield return new Language { Id = Guid.Parse("47f3cc11-d37c-4d58-908e-7d7f71d190ca"), TypeId = Guid.Parse("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0"), Name = "Skald" };
            yield return new Language { Id = Guid.Parse("a025c8bf-03d7-44cf-8571-444a80799ab6"), TypeId = Guid.Parse("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0"), Name = "Tien" };
            yield return new Language { Id = Guid.Parse("0f1df7b2-68f8-41db-8800-2a72f8b41cad"), TypeId = Guid.Parse("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0"), Name = "Varisian" };
            yield return new Language { Id = Guid.Parse("70fb4b94-4ba8-4f1f-82ed-e160ce7eb99d"), TypeId = Guid.Parse("c6a0d0e3-a9cd-4c6f-ad6c-e5cf491784a0"), Name = "Vuldrani" };
 
            yield return new Language { Id = Guid.Parse("2e093e71-03bf-46bb-9c3e-29066e49c891"), TypeId = Guid.Parse("705b76de-5a42-4e7b-aaf2-16feb7b232d0"), Name = "Sign Language" };
        }
    }
}